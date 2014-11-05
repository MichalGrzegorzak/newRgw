using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kanc.Commons
{
    /// <summary>
    /// nic to nie daje bo i tak nie ma jak tego mapowac w nhibernate, trzeba by kazdy typ, extra mapper pisac
    /// </summary>
    public class EmailTemplate : IEmailTemplate
    {
        public static readonly EmailTemplate Welcome = new EmailTemplate(0, "File1.html");
        public static readonly EmailTemplate Confirm = new EmailTemplate(1, "File2.html");
        public EmailTemplate()
        {
            //to jest dla picu
        }

        private EmailTemplate(int value, string description)
        {
            Desc = description;
            Val = value;
            //Name = name;
        }
        public string Desc { get; private set; }
        public string Name { get; private set; }
        public int Val { get; private set; }

        private static readonly SortedList<string, EmailTemplate> keyValuePairs = new SortedList<string, EmailTemplate>();

        static EmailTemplate()
        {
            foreach (FieldInfo info in typeof (EmailTemplate).GetFields())
            {
                if (info.IsStatic && info.IsPublic && info.FieldType == typeof(EmailTemplate))
                {
                    keyValuePairs.Add(info.Name, (EmailTemplate)info.GetValue(typeof(EmailTemplate)));
                }
            }
        }



        #region Lookup functions

        /// <summary>
        /// Determines whether the specified value is defined.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is defined; otherwise, <c>false</c>.
        /// </returns>
        //public static bool IsDefined(int value) { return keyValuePairs.ContainsValue(value); }

        /// <summary>
        /// Parses the specified value from the name.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <returns>The value associated with the name.</returns>
        public int Parse(string name)
        {
            if (keyValuePairs.ContainsKey(name))
            {
                EmailTemplate item = keyValuePairs[name];
                return item.Val;
            }
            else
            {
                return 0;
            }
        }

        public IEmailTemplate Parse2(string name)
        {
            if (keyValuePairs.ContainsKey(name))
            {
                return keyValuePairs[name];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the name associated with a specific value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The name associated with the value.</returns>
        public string GetName(int value)
        {
            foreach (KeyValuePair<string, EmailTemplate> keyValuePair in keyValuePairs)
            {
                if (keyValuePair.Value.Val == value)
                    return keyValuePair.Key;
            }
            return null;
        }

        /// <summary>
        /// Gets the assigned names.
        /// </summary>
        /// <returns>The assigned names in alphabetical order.</returns>
        public string[] GetNames()
        {
            string[] tempArray = new string[keyValuePairs.Keys.Count];
            keyValuePairs.Keys.CopyTo(tempArray, 0);
            return tempArray;
        }

        /// <summary>
        /// Gets the value associated with a specific name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The value associated with the name.</returns>
        public int GetValue(string name)
        {
            if (keyValuePairs.ContainsKey(name))
            {
                return keyValuePairs[name].Val;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the assigned values.
        /// </summary>
        /// <returns>The assigned values sorted by the alphabetical order of their names.</returns>
        public int[] GetValues()
        {
            int[] tempArray = new int[keyValuePairs.Values.Count];
            int idx = 0;
            foreach (var keyValuePair in keyValuePairs)
            {
                tempArray[idx] = keyValuePair.Value.Val;
            }
            return tempArray;
        }

        #endregion

    }

    public interface IEmailTemplate
    {
        string Desc { get; }
        int Val { get; }

        /// <summary>
        /// Determines whether the specified value is defined.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is defined; otherwise, <c>false</c>.
        /// </returns>
        //public static bool IsDefined(int value) { return keyValuePairs.ContainsValue(value); }

        /// <summary>
        /// Parses the specified value from the name.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <returns>The value associated with the name.</returns>
        int Parse(string name);

        IEmailTemplate Parse2(string name);

        /// <summary>
        /// Gets the name associated with a specific value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The name associated with the value.</returns>
        string GetName(int value);

        /// <summary>
        /// Gets the assigned names.
        /// </summary>
        /// <returns>The assigned names in alphabetical order.</returns>
        string[] GetNames();

        /// <summary>
        /// Gets the value associated with a specific name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The value associated with the name.</returns>
        int GetValue(string name);

        /// <summary>
        /// Gets the assigned values.
        /// </summary>
        /// <returns>The assigned values sorted by the alphabetical order of their names.</returns>
        int[] GetValues();
    }

}