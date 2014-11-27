using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Tests
{
    public class B1
    {
        [Test]
        public void Test1()
        {
            Regex objRegExp = new Regex("(?!</?p>|</?.?br>)<(.|\n)+?>");
            String strOutput = objRegExp.Replace(text, String.Empty);
            Assert.IsTrue("a12, 340[]" == strOutput);
        }


        private string text = @"
//<meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
<br>
</br>
</ br>
<p>dgdsg</p>
<meta name='ProgId' content='Word.Document' />
<meta name='Generator' content='Microsoft Word 11' />
<meta name='Originator' content='Microsoft Word 11' />
<link rel='File-List' href='file:///C:%5CDOCUME%7E1%5Csylvie%5CLOCALS%7E1%5CTemp%5Cmsohtml1%5C01%5Cclip_filelist.xml' />
<style>
st1':*{behavior:url(#ieooui) }
</style>
<![endif]--><style>
<!--
/* Style Definitions */
{mso-style-name:'Table Normal';
mso-style-parent:'';
font-size:10.0pt;
font-family:'Times New Roman';}
</style>
<![endif]-->
<p><strong><span>ABaC
Hotel &amp; Restaurant Awarded in Conde Nast Traveller Hot List 2009</span></strong></p>
<p><span>Since opening its doors in May of 2008,
ABaC Hotel &amp; Restaurant has been bringing style and luxury to Barcelona. The hotel has
been awarded by Conde Nast Traveller, after an incognito visit, evaluating the
establishment according to a standard set of criteria.</span></p>
    }
}";
    
}
}
