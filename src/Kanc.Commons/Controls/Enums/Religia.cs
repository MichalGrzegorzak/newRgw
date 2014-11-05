namespace Kanc.Commons
{
    public enum Relgia
    {
        [EnumDescription("keine")]
        keine = 0, //ohne Konfession, bez wyznania do 2004 = VD
        [EnumDescription("römisch-katholische")]
        RK = 1, //römisch-katholische Kirchensteuer
        [EnumDescription("evangelische")]
        EV = 2, //evangelische
        [EnumDescription("evangelisch lutherisch")]
        LT = 3, //evangelisch lutherisch
        [EnumDescription("evangelisch reformiert")]
        RF = 4, //evangelisch reformiert
        [EnumDescription("israelitische Kultussteuer")]
        IS = 5, //israelitische Kultussteuer
        [EnumDescription("jüdische Kultussteuer")]
        JD = 6, //jüdische Kultussteuer
        [EnumDescription("französisch reformiert")]
        FR = 7, //französisch reformiert
        [EnumDescription("altkatholische")]
        AK = 8  //altkatholische
    }

    public class ReligiaHelper
    {
        public static int ConvertReligia(string input, int rok)
        {
            Relgia result = Relgia.keine;

            switch (input.ClearText())
            {
                case "ev.ref": result = Relgia.RF; break;
                case "ev.-luth": result = Relgia.LT; break;
                case "ev.":
                case "EV": result = Relgia.EV; break;
                case "RK":
                case "röm-kath": result = Relgia.RK; break;
                case "VD":
                case "keine": result = Relgia.keine; break;
                default: result = Relgia.keine; break;
            }
            return (int)result;
        }
    }
}
