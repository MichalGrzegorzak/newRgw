using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Core
{
   /// <summary>
    /// www = http://szewo.com/php/nrb.phtml?nrb=12102037140000430200148759
    /// http://www.coderscity.pl/ftopic8490.html
    /// http://wipos.p.lodz.pl/zylla/ut/banki.html
   /// </summary>
    public class WalidujKonto
    {
        //12102037140000430200148759 dobry numer

        public  bool Validate(Int64 nrKonta)
        {
            string konto = nrKonta.ToString();
            if (konto.Length != 26)
                return false;

            int[] W = new int[] {1,10,3,30,9,90,27,76,81,34,49,5,50,15,53,45,62,38,89,17,73,51,25,56,75,71,31,19,93,57};
            konto += "2521"; //PL
            konto = konto.Substring(2) + konto.Substring(0, 2);

            Int64 Z =0;
            for (int i=0; i<30; i++)
            {
                Z += Int32.Parse(konto[29 - i].ToString()) * W[i];
            }

            if (Z % 97 == 1)
                return true;
            else
            {
                return false;
            }
        }



    }
}
