using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Kanc.Commons;

namespace Kanc.MVP.Presentation.Customers
{
    public class BasicValidator<TObject> where TObject : Control //, IView
    {
        public enum RulesEnum
        {
            None,
            IsRequired,
            IsNumber,
            IsCorrectAge
        }

        private Dictionary<string, List<RulesEnum>> rulesDict = new Dictionary<string, List<RulesEnum>>();
        private Dictionary<string, string> controlToPropNameDict = new Dictionary<string, string>(); 
        private ErrorProvider errorProvider;
        private bool hasError;
        private TObject view;

        public BasicValidator(TObject view, ErrorProvider errorProvider) 
        {
            this.errorProvider = errorProvider;
            this.view = view;
        }

        public bool Validate(Control ctrl)
        {
            //clear error
            errorProvider.SetError(ctrl, "");

            bool hasError = false;
            var list = rulesDict[ctrl.Name];
            string propName = controlToPropNameDict[ctrl.Name];

            foreach (RulesEnum rule in list)
            {
                switch (rule)
                {
                    case RulesEnum.None:
                        break;
                    case RulesEnum.IsRequired:
                        if (ctrl.Text.Trim().Length == 0)
                        {
                            errorProvider.SetError(ctrl, "{0} jest wymagane".Frmt(propName)); 
                            hasError = true;
                        }
                        break;
                    case RulesEnum.IsNumber:
                        if (RegexHelper.DigitRegex.IsMatch(ctrl.Text) == false)
                        {
                            errorProvider.SetError(ctrl, "{0} musi byc liczba".Frmt(propName));
                            hasError = true;
                        }
                        break;
                    case RulesEnum.IsCorrectAge:
                        int val = ctrl.Text.ParseSafe<int>();
                        if (!(val > 18 && val < 111))
                        {
                            errorProvider.SetError(ctrl, "{0} musi byc liczba z przedziału od 18 do 111".Frmt(propName));
                            hasError = true;
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if(hasError)
                    break;
            }
            return hasError;
        }

        /// <summary>
        /// Wykorzystuje konwencje -> PROP = txbPROP
        /// </summary>
        public ValRules For<TProperty>(Expression<Func<TObject, TProperty>> expression)
        {
            string propertyName = PropertyResolver.GetMemberName(expression);
            string ctrlName = "txb" + propertyName;
#if DEBUG
            var found = ControlHelper.FindTextBoxByName(view, ctrlName);
            if(found == null) throw new Exception("nie znaleziono textBoxa - " + ctrlName);
#endif
            controlToPropNameDict.Add(ctrlName, propertyName);
            return new ValRules(rulesDict, ctrlName);
        }
        public ValRules For(string ctrlName, string propertyName)
        {
            controlToPropNameDict.Add(ctrlName, propertyName);
            return new ValRules(rulesDict, ctrlName);
        }

        public class ValRules
        {
            public Dictionary<string, List<RulesEnum>> dict;
            public string ctrlName;

            public ValRules(Dictionary<string, List<RulesEnum>> dict, string ctrlName)
            {
                this.dict = dict;
                this.ctrlName = ctrlName;
            }
            private void AddRule(RulesEnum renum)
            {
                var list = dict.ContainsKey(ctrlName) ? dict[ctrlName] : new List<RulesEnum>();
                list.Add(renum);
                dict[ctrlName] = list;
            }

            public ValRules IsRequired()
            {
                AddRule(RulesEnum.IsRequired);
                return this;
            }
            public ValRules IsNumber()
            {
                AddRule(RulesEnum.IsNumber);
                return this;
            }
            public ValRules IsCorrectAge()
            {
                AddRule(RulesEnum.IsRequired);
                AddRule(RulesEnum.IsNumber);
                AddRule(RulesEnum.IsCorrectAge);
                return this;
            }
        }

        
    }
}