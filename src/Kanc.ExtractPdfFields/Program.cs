using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.ExtractPdfFields
{
    /// <summary>
    /// UWAGA - generuje wszystki pliki - aly tylko klasy BASE
    /// czyta pliki .fdf z UI raporty (generuj z foxit -> export form data)
    /// extractor buduja base classe z polami
    /// dodatkowo generujemy plik 12345 - ktory mozna uzyc ??
    /// </summary>
    class Program
    {
        //static List<string> BaseFieldsExcluded = new List<string>(new[] {
        //            "Imie","Zawod","AdresKod","AdresUlica","Religia","Steuernummer",
        //            "Urodzony","AdresMiasto","Data","Adres","BankKonto","BankKod","BankAdres",
        //            "FirmaPoczta","FirmaAdres","FirmaOkreg","FirmaNazwa1","FirmaNazwa2",
        //            "ZonaImie","ZonaData","ZonaReligia"
        //                                         }); 

        static List<string> BaseFieldsExcluded = new List<string>(new[] {
                    "Podpis", "PartnerPodpis"
                                                 }); 

        static void Main(string[] args)
        {
            string directoryPath = @"d:\PROJECTS\mine\Rogow\proj\Kancelaria\Kanc.UI\Raporty\DE\";
            foreach (string path in Directory.GetFiles(directoryPath, "*.fdf") )
                //Where(x=>x.Contains("13_")))
            {
                Extractor extr = new Extractor(path);
            }

            //wygeneruj plik z polami ktore sie czesto powtarzaja wiecej niz raz i uzyc ich w base klasie
            using (StreamWriter writer = File.CreateText(@"C:\12345.txt"))
            {
                foreach (var pair in Extractor.AllFieldsDict
                    .Where(x=>!x.Key.Contains("t."))
                    .Where(x=>x.Value > 1)
                    .OrderByDescending(x => x.Value))
                {
                    writer.WriteLine("public string " + ParseToPropName(pair.Key) + " = \"" + pair.Key + "\"; ");
                }
            }
        }

        public static string ParseToPropName(string input)
        {
            input = input.Replace(" ", "");
            input = input.Replace(".", "_");
            //(/
            return input.FirstCharToUpper();
        }

        public static string ParseToClassName(string input)
        {
            input = input.Replace(" ", "");
            input = input.Replace(".", "_");
            return input.FirstCharToUpper();
        }

        public static bool ShouldSkipThisKey(string key)
        {
            if (BaseFieldsExcluded.Contains(key))
                return true;
            if (key.StartsWith("cx") || key.StartsWith("rb") || key.StartsWith("t."))
                return true;
            return false;
        }
    }
}
