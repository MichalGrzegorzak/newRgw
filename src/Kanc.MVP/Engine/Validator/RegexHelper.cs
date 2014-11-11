using System.Text.RegularExpressions;

namespace Kanc.MVP.Presentation.Customers
{
    public static class RegexHelper
    {
        public static Regex DigitRegex = new Regex(@"^(\d{1,})$", RegexOptions.Compiled);
        public static Regex AgeRegex = new Regex(@"^(1[8-9]|[2-9]\d|\d{3,})$", RegexOptions.Compiled);
        public static Regex EmailRegex = null;
        public static Regex PhoneRegex = null;
        // od 18
    }
}