using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kanc.Commons;

namespace Kanc.ExtractPdfFields
{
    public enum TypPola
    {
        Text,
        CheckBox,
    }
    
    public class Extractor
    {
        public static SortedDictionary<string, int> AllFieldsDict = new SortedDictionary<string, int>();
        SortedDictionary<string, string> FieldsDict = new SortedDictionary<string, string>();

        private string Name;
        private string Path;
        
        public Extractor(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileNameWithoutExtension(path);

            ExtractFields();
            
            SaveFieldsAsTxt();
            GenerateClass();
        }

        private void SaveFieldsAsTxt()
        {
            using (TextWriter writer = File.CreateText(Path.Replace(".fdf", ".txt")))
            {
                writer.NewLine = "\r\n";
                foreach (KeyValuePair<string, string> pair in FieldsDict)
                {
                    writer.WriteLine(pair.Key);
                }
                writer.WriteLine("\r\n");
                writer.WriteLine("\r\n");

                foreach (KeyValuePair<string, string> pair in FieldsDict.Where(x=>x.Value.IsNotNullOrEmpty()) )
                {
                    writer.WriteLine(pair.Key + ";" + pair.Value.ToString());
                }
            }
        }

        private void ExtractFields()
        {
            string content = File.ReadAllText(Path);
            content = content.CutBetween("/Fields[", "]>>>>");
            string[] fields = content.Split(new[] {">><<"}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string field in fields)
            {
                string s = field.ReplaceAllOf("", "<<", ">>","/T(",")");
                string typ = "";
                //TypPola typ = TypPola.Text;
                //if (s.Contains("/V"))
                //{
                //    s = s.ReplaceAllOf("", "/V", "/Off", "/On");
                //    typ = TypPola.CheckBox;
                //}
                if (s.Contains('/'))
                {
                    int idx = s.IndexOf('/');
                    typ = s.Substring(idx, s.Length - idx);
                    if (!typ.Contains("/V"))
                    {
                        string w = "";
                    }
                    s = s.ReplaceAllOf("", "/V", "/Off", "/On");
                    //slownik juz zawiera typ
                    //potem pobija kontrolki zaczynajace sie na rb cx 
                }
                FieldsDict.Add(s, typ);

                if (AllFieldsDict.ContainsKey(s))
                    AllFieldsDict[s] = AllFieldsDict[s] + 1;
                else
                    AllFieldsDict.Add(s, 1);
            }
        }

        public void GenerateClass()
        {
            string name = Name.Substring(3);
            string path = @"d:\PROJECTS\mine\Rogow\proj\Kancelaria\Kanc.Core\Features\Raporty\DE\Base\" + Name + ".cs";
            
            //string path = Path.Replace(".fdf", ".cs");
            StringBuilder builder = new StringBuilder();
            string sw = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Core.Entities;

namespace Kanc.Core.Features.Raporty.DE
{
    public class Base" + Program.ParseToClassName(name) + @" : BaseRpt
    {";
            builder.Append(sw);
            builder.AppendLine("");
            foreach (KeyValuePair<string, string> pair in FieldsDict)
            {
                if(Program.ShouldSkipThisKey(pair.Key))
                    continue;

                builder.AppendLine("\t\tpublic string {0}".Frmt(Program.ParseToPropName(pair.Key)));
                builder.AppendLine("\t\t{");
                builder.AppendLine("\t\t\tget { return Fields[\"" + pair.Key + "\"]; }");
                builder.AppendLine("\t\t\tset { Fields[\"" + pair.Key + "\"] = value; }");
                builder.AppendLine("\t\t}");
            }
            builder.AppendLine("");
            builder.AppendLine("\t\tpublic override void AddPropertiesToFields() \n\t\t{");
            foreach (KeyValuePair<string, string> pair in FieldsDict)
            {
                if (Program.ShouldSkipThisKey(pair.Key))
                    continue;
                builder.AppendLine("\t\t\tFields.Add(\"{0}\",\"{0}\");".Frmt(pair.Key));
            }
            sw= @"
        }
    }
}";
            builder.Append(sw);

            using (StreamWriter writer = File.CreateText(path))
            {
                //writer.Encoding.
                writer.Write(builder.ToString());
            }
        }
    }
}
