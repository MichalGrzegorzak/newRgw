using System.Collections.Generic;
using Utils.Features.ExtendentEnum;

namespace Kanc.MVP.Engine.Validator
{
    public class ValRules
    {
        public Dictionary<string, List<RuleDef>> mapControlToRules;
        public string ctrlName;

        public ValRules(Dictionary<string, List<RuleDef>> mapControlToRules, string ctrlName)
        {
            this.mapControlToRules = mapControlToRules;
            this.ctrlName = ctrlName;
        }
        private void AddRule(ValidationRulesEnum renum, string message)
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
            AddRule(ValidationRulesEnum.IsRequired, message);
            return this;
        }
        public ValRules IsNumber(string message = null)
        {
            AddRule(ValidationRulesEnum.IsNumber, message);
            return this;
        }
        public ValRules IsCorrectAge(string message = null)
        {
            AddRule(ValidationRulesEnum.IsRequired, message);
            AddRule(ValidationRulesEnum.IsNumber, message);
            AddRule(ValidationRulesEnum.IsCorrectAge, message);
            return this;
        }
    }
}