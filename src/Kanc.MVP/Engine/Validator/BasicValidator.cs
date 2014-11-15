using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kanc.MVP.Presentation.Customers;
using Utils.Extensions;
using Utils.Features.ExtendentEnum;
using Utils.Features.Reflection;
using Utils.Features.TypesParsing;

namespace Kanc.MVP.Engine.Validator
{
    public enum ValidationRulesEnum
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

    public class BasicValidator<TView> where TView : class, IMyBaseView//, IView //, IView
    {
        private Dictionary<string, List<RuleDef>> rulesDict = new Dictionary<string, List<RuleDef>>();
        private Dictionary<string, string> mapControlNameToPropNameDict = new Dictionary<string, string>();
        private List<KeyValuePair<Control, string>> errorMessages = new List<KeyValuePair<Control, string>>();

        private bool hasError;
        private TView view;

        public BasicValidator(TView view)
        {
            this.view = view;
        }

        public List<string> Errors
        {
            get { return errorMessages.Select(x=>x.Value).ToList(); }
        }

        public bool ValidateViewModel(TView model)
        {
            var properties = typeof(TView).GetProperties().Where(p => p.CanRead);

            List<string> namesToValidate = mapControlNameToPropNameDict.Values.ToList();

            int found = 0;
            bool hasError = false;
            foreach (var propertyInfo in properties)
            {
                string name = propertyInfo.Name;
                if (namesToValidate.Contains(name))
                {
                    found++;

                    var dictEntry = mapControlNameToPropNameDict.FirstOrDefault(x => x.Value == name);
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
            string propName = mapControlNameToPropNameDict[ctrlName];

            hasError = InternalValidate(ctrl, ctrl.Text.Trim(), propName, list);
            if (hasError)
            {
                return errorMessages.FirstOrDefault().Value;
            }
            return null;
        }

        

        private bool InternalValidate(Control ctrl, string value, string propName, List<RuleDef> list, bool validateAll = false)
        {
            bool hasError = false;
            errorMessages = new List<KeyValuePair<Control, string>>();

            foreach (RuleDef ruleDef in list)
            {
                switch (ruleDef.Definition)
                {
                    case ValidationRulesEnum.None:
                        break;
                    case ValidationRulesEnum.IsRequired:
                        if (value.Length == 0)
                            hasError = true;
                        break;
                    case ValidationRulesEnum.IsNumber:
                        if (RegexHelper.DigitRegex.IsMatch(value) == false)
                            hasError = true;
                        break;
                    case ValidationRulesEnum.IsCorrectAge:
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
            mapControlNameToPropNameDict.Add(ctrlName, propertyName);
            return new ValRules(rulesDict, ctrlName);
        }

        private static string FrmtMessage(RuleDef ruleDef, string propName)
        {
            string result = ruleDef.Message;
            if (result.Contains("{0}"))
                result = result.Frmt(propName);
            return result;
        }

        

        
    }
}