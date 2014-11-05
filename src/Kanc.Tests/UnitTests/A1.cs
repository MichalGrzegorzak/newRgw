using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ElvTools.Ext;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Tests
{
    public class A1
    {
        string test;

        [Test]
        public void Test1()
        {
            test = @"a1.2,   3    4/0\[]";
            test = test.RemoveAllOf(".", "/", "\\","  ");
            Assert.IsTrue("a12, 340[]" == test);
        }

        [Test]
        public void Test2()
        {
            test = @"a1.2,  3   4/0\[]ąśźćżółŹÓ";
            test = test.RegexOnlyDigits('.');
            Assert.IsTrue("1.2340" == test);
        }

        [Test]
        public void Test3()
        {
            test = @"a1.2,  3   4/0\[]ąśźćżółŹÓ";
            test = test.RegexOnlyLetters();
            Assert.IsTrue("aąśźćżółŹÓ" == test);
        }

       

        [Test]
        public void Test8()
        {
            string input = @" Michał   Grzegorzak ";
            string regex = @"[^A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]*[,.\s]+";
            var reg = new Regex(regex, RegexOptions.Compiled);
            string s = reg.Replace(input, "");
            s = "";
        }
    }
}
