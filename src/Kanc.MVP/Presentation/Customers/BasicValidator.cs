using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Kanc.Commons;
using MVCSharp.Core.Views;

namespace Kanc.MVP.Presentation.Customers
{
    public static class PropertyInfoExtensions
    {
        public static Func<T, object> GetValueGetter<T>(this PropertyInfo propertyInfo)
        {
            if (typeof(T) != propertyInfo.DeclaringType)
            {
                throw new ArgumentException();
            }

            var instance = Expression.Parameter(propertyInfo.DeclaringType, "i");
            var property = Expression.Property(instance, propertyInfo);
            var convert = Expression.TypeAs(property, typeof(object));
            return (Func<T, object>)Expression.Lambda(convert, instance).Compile();
        }

        public static Action<T, object> GetValueSetter<T>(this PropertyInfo propertyInfo)
        {
            if (typeof(T) != propertyInfo.DeclaringType)
            {
                throw new ArgumentException();
            }

            var instance = Expression.Parameter(propertyInfo.DeclaringType, "i");
            var argument = Expression.Parameter(typeof(object), "a");
            var setterCall = Expression.Call(
                instance,
                propertyInfo.GetSetMethod(),
                Expression.Convert(argument, propertyInfo.PropertyType));
            return (Action<T, object>)Expression.Lambda(setterCall, instance, argument).Compile();
        }
    }

    public class BasicValidator<TView> where TView : class, IMyBaseView//, IView //, IView
    {
        public enum RulesEnum
        {
            [EnumDescription("Brak reguly ??")]
            None,
            [EnumDescription("Pole jest wymagane")]
            IsRequired,
            [EnumDescription("Musi byc liczba")]
            IsNumber,
            [EnumDescription("Nie poprawny wiek")]
            IsCorrectAge
        }

        private Dictionary<string, List<RuleDef>> rulesDict = new Dictionary<string, List<RuleDef>>();
        private Dictionary<string, string> controlToPropNameDict = new Dictionary<string, string>();
        private List<KeyValuePair<Control, string>> errorMessages = new List<KeyValuePair<Control, string>>();

        public List<string> Errors
        {
            get { return errorMessages.Select(x=>x.Value).ToList(); }
        }

        private bool hasError;
        private TView view;

        public BasicValidator(TView view)
        {
            this.view = view;
        }

        public bool ValidateViewModel(TView model)
        {
            var properties = typeof(TView).GetProperties().Where(p => p.CanRead);

            List<string> namesToValidate = controlToPropNameDict.Values.ToList();

            int found = 0;
            bool hasError = false;
            foreach (var propertyInfo in properties)
            {
                string name = propertyInfo.Name;
                if (namesToValidate.Contains(name))
                {
                    found++;

                    var dictEntry = controlToPropNameDict.FirstOrDefault(x => x.Value == name);
                    var list = rulesDict[dictEntry.Key];

                    var lambda = propertyInfo.GetValueGetter<TView>();
                    object value = lambda(model);

                    bool result = InternalValidate(null, value.ToString(), name, list, validateAll: true);
                    if (!hasError)
                        hasError = result;
                }
            }

            if (found != namesToValidate.Count)
            {
                string s = "alles in ordung ?";
            }

            return hasError;
        }

        public string ValidateControl(Control ctrl)
        {
            bool hasError = false;
            string ctrlName = ctrl.Name;

            if (!rulesDict.ContainsKey(ctrlName)) //kontrolka nie ma zdefniowanej reguly
            {
                return null;
            }

            var list = rulesDict[ctrlName];
            string propName = controlToPropNameDict[ctrlName];

            hasError = InternalValidate(ctrl, ctrl.Text.Trim(), propName, list);
            if (hasError)
            {
                return errorMessages.FirstOrDefault().Value;
            }
            return null;
        }

        private static string FrmtMessage(RuleDef ruleDef, string propName)
        {
            string result = ruleDef.Message;
            if (result.Contains("{0}"))
                result = result.Frmt(propName);
            return result;
        }

        private bool InternalValidate(Control ctrl, string value, string propName, List<RuleDef> list, bool validateAll = false)
        {
            bool hasError = false;
            errorMessages = new List<KeyValuePair<Control, string>>();

            foreach (RuleDef ruleDef in list)
            {
                switch (ruleDef.Definition)
                {
                    case RulesEnum.None:
                        break;
                    case RulesEnum.IsRequired:
                        if (value.Length == 0)
                            hasError = true;
                        break;
                    case RulesEnum.IsNumber:
                        if (RegexHelper.DigitRegex.IsMatch(value) == false)
                            hasError = true;
                        break;
                    case RulesEnum.IsCorrectAge:
                        int val = value.ParseSafe<int>();
                        if (!(val > 18 && val < 111))
                            hasError = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (hasError)
                {
                    string message = FrmtMessage(ruleDef, propName);
                    errorMessages.Add(new KeyValuePair<Control, string>(ctrl, message));

                    if (!validateAll)
                        break;
                }
            }
            return hasError;
        }

        /// <summary>
        /// Mozna uzywac konwencji -> PROP = txbPROP
        /// </summary>
        public ValRules For<TProperty>(Expression<Func<TView, TProperty>> expression, string ctrlName = null)
        {
            string propertyName = PropertyResolver.GetMemberName(expression);
            ctrlName = ctrlName ?? "txb" + propertyName;

            return For(propertyName, ctrlName);
        }
        public ValRules For(string propertyName, string ctrlName)
        {
            controlToPropNameDict.Add(ctrlName, propertyName);
            return new ValRules(rulesDict, ctrlName);
        }

        public class RuleDef
        {
            public RuleDef(RulesEnum renum, string message)
            {
                this.Definition = renum;
                this.Message = message;
            }

            public RulesEnum Definition { get; set; }
            public string Message { get; set; }

            public override bool Equals(object obj)
            {
                var item = obj as RuleDef;

                if (item == null)
                    return false;

                return this.Definition.Equals(item.Definition);
            }

            public override int GetHashCode()
            {
                return this.Definition.GetHashCode();
            }
        }

        public class ValRules
        {
            public Dictionary<string, List<RuleDef>> mapControlToRules;
            public string ctrlName;

            public ValRules(Dictionary<string, List<RuleDef>> mapControlToRules, string ctrlName)
            {
                this.mapControlToRules = mapControlToRules;
                this.ctrlName = ctrlName;
            }
            private void AddRule(RulesEnum renum, string message)
            {
                message = message ?? EnumHelper.GetDescription(renum);

                var rulesList = mapControlToRules.ContainsKey(ctrlName) ? mapControlToRules[ctrlName] : new List<RuleDef>();
                RuleDef def = new RuleDef(renum, message);

                if (!rulesList.Contains(def))
                    rulesList.Add(def);

                mapControlToRules[ctrlName] = rulesList;
            }

            public ValRules IsRequired(string message = null)
            {
                AddRule(RulesEnum.IsRequired, message);
                return this;
            }
            public ValRules IsNumber(string message = null)
            {
                AddRule(RulesEnum.IsNumber, message);
                return this;
            }
            public ValRules IsCorrectAge(string message = null)
            {
                AddRule(RulesEnum.IsRequired, message);
                AddRule(RulesEnum.IsNumber, message);
                AddRule(RulesEnum.IsCorrectAge, message);
                return this;
            }
        }

        
    }
}