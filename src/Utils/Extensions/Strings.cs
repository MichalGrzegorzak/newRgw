using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utils.Extensions
{
    public static class StringExt
    {
        /// <summary>
        /// Capitalize only the first letter
        /// </summary>
        public static string FirstCharToUpper(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }

        /// <summary>
        /// Capitalize each word in whole sentence
        /// </summary>
        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }


        public static string IfValueThenShortDate(this DateTime? date)
        {
            if (date.HasValue)
                return date.Value.ToShortDateString();
            return string.Empty;
        }

        public static bool IsNotNullOrEmpty(this string text)
        {
            return !string.IsNullOrEmpty(text);
        
        }

        public static bool IsNotNullOrEmptyT(this string text)
        {
            if (!string.IsNullOrEmpty(text))
                text = text.Trim();

            return !string.IsNullOrEmpty(text);
        }

        public static string Truncate(this string text, int length, string ending, bool keepFullWordAtEnd)
        {
            if (!text.IsNotNullOrEmpty())
                return string.Empty;

            if (text.Length < length)
                return text;

            text = text.Substring(0, length);

            if (keepFullWordAtEnd)
            {
                text = text.Substring(0, text.LastIndexOf(' '));
            }

            return text + ending;
        }

        public static string Substring(this string text, string fromAWord)
        {
            int idx = text.IndexOf(fromAWord);
            if (idx > 0)
            {
                idx = idx + fromAWord.Length;
                text = text.Substring(idx);
            }
            return text;
        }

        // Enable quick and more natural string.Format calls
        public static string Frmt(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static string CutBetween(this string input, string begin, params string[] end)
        {
            string result = "";

            int idx = input.IndexOf(begin) + begin.Length;
            input = input.Substring(idx);
            int edx = -1;
            foreach (string s in end)
            {
                if(input.IndexOf(s) > 0)
                {
                    edx = input.IndexOf(s);
                    break;
                }
            }

            if(edx > -1)
                result = input.Substring(0, edx);

            return result;
        }

        public static string RegexOnlyDigits(this string input, params char[] additionally)
        {
            //"y0urstr1ngW1thNumb3rs".Where(x => Char.IsDigit(x)).ToArray()); //linq alterbative

            string regex = @"[^0-9{0}]*";
            regex = regex.Frmt(AddFromArray(additionally));
            
            var reg = new Regex(regex, RegexOptions.Compiled);
            return RegexRemove(input, reg);
        }

        private static string AddFromArray(char[] additionally)
        {
            string result = "";
            foreach (char c in additionally)
                result += c;
            
            return result;
        }
        public static string RegexOnlyLetters(this string input, params char[] additionally)
        {
            //Char.IsLetter for linq
            string regex = @"[^A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ{0}]*";
            regex = regex.Frmt(AddFromArray(additionally));

            var reg = new Regex(regex, RegexOptions.Compiled);
            return RegexRemove(input, reg);
        }

        public static string ClearText(this string input)
        {
            input = input.Trim();
            input = input.Replace("  ", " ");
            input = input.Replace("  ", " ");
            input = input.RemoveAllOf(";", ":");
            return input;
        }

        //public static string RegexOnlyWords(this string input, params char[] additionally)
        //{
        //    string regex = @"[^A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]*[,.\s]+";
        //    regex = regex.Frmt(AddFromArray(additionally));

        //    var reg = new Regex(regex, RegexOptions.Compiled);
        //    return RegexRemove(input, reg);
        //}
        public static string RegexRemove(this string input, Regex reg)
        {
            return input = reg.Replace(input, "");
        }

        // public static int[ ] ExtractInts( this string s )
        //{
        //    return s.REExtract<int>( @"\d+" );
        //}
        //int[] a = "Some primes: 2, 5, 11, and 17".ExtractInts();
        //// a == { 2, 5, 11, 17 }
        /// <summary>
        /// look up
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public static T[] REExtract<T>(this string s, string regex)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(T));
            if (!tc.CanConvertFrom(typeof(string)))
            {
                throw new ArgumentException("Type does not have a TypeConverter from string", "T");
            }
            if (!string.IsNullOrEmpty(s))
            {
                return
                    Regex.Matches(s, regex)
                    .Cast<Match>()
                    .Select(f => f.ToString())
                    .Select(f => (T)tc.ConvertFrom(f))
                    .ToArray();
            }
            else
                return new T[0];
        }

        /// <summary>
        /// Makes the string from list
        /// </summary>
        /// <param name="list">list of strings</param>
        /// <returns>word1|word2|word3</returns>
        public static string ToLine<T>(this List<T> list)
        {
            return ToLine(list, "|");
        }

        public static string ToLine<T>(this List<T> list, string separator)
        {
            string result = "";
            foreach (T s in list)
            {
                string r = s.ToString();
                if(typeof(T) == typeof(DateTime))
                {
                    r = r.Replace(" 00:00:00", "");
                }
                result += r + separator;
            }
            
            if(result.Length > 1) //usun ostatni separator
                result = result.Remove(result.Length - 1, 1);

            return result;
        }

        public static bool IsSame(this string input, string other)
        {
            if (!input.IsNotNullOrEmptyT() || !other.IsNotNullOrEmptyT())
                throw new Exception("Nie moze byc null or empty!");

            input = input.Trim().ToLower();
            other = other.Trim().ToLower();

            if (input == other)
                return true;

            return false;
        }

        public static string Reverse(this string input)
        {
            if (input.IsNotNullOrEmptyT())
            {
                char[] arr = input.ToCharArray().Reverse().ToArray();
                input = new string(arr, 0, arr.Length);
            }
            return input;
        }

        public static string RemoveLast(this string input)
        {
            return input.Remove(input.Length - 1, 1);
        }

        public static string RemoveLast(this string input, string character)
        {
            if (input.IsNotNullOrEmptyT())
            {
                input = input.Reverse();
                character = character.Reverse();
                int idx = input.IndexOf(character);
                if (idx > -1)
                {
                    input = input.Substring(0, idx);
                }

                input = input.Reverse();
            }
            return input;
        }

        public static string RemoveAllOf(this string input, params string[] slowa)
        {
            return ReplaceAllOf(input, "", slowa);
        }
        public static string ReplaceAllOf(this string input, string to, params string[] slowa)
        {
            foreach (string s in slowa)
            {
                input = input.Replace(s, to);
            }
            return input;
        }
        public static string ReplaceAllOf(this string input,char to, params char[] znaki)
        {
            foreach (char c in znaki)
            {
                input = input.Replace(c, to);
            }
            return input;
        }
        public static bool IsExistAny(this string input, params char[] znaki)
        {
            foreach (char c in znaki)
            {
                if(input.IndexOf(c) > -1)
                    return true;
            }
            return false;
        }

        public static bool Contains(this string input, params string[] list)
        {
            foreach (string s in list)
            {
                if (input.ToLower().Contains(s.ToLower()))
                    return true;
            }
            return false;
        }

        public static bool ContainsOneOf(this string input, params string[] slowa)
        {
            foreach (string s in slowa)
            {
                if (input.Contains(s))
                    return true;
            }
            return false;
        }

        public static bool ContainsAllOf(this string input, params string[] slowa)
        {
            foreach (string s in slowa)
            {
                if (!input.Contains(s))
                    return false;
            }
            return true;
        }

        
    }
}
