namespace Kanc.MVP.Engine.Validator
{
    public class RuleDef
    {
        public RuleDef(ValidationRulesEnum renum, string message)
        {
            this.Definition = renum;
            this.Message = message;
        }

        public ValidationRulesEnum Definition { get; set; }
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
}