using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarSamsar
{
    class CnpValidator
    {
        static readonly string strRegex = "([1-9])([0-9]\\d|[0-9])(0[1-9]|1[0-2])(0[1-9]|[12]\\d|3[01])(0[1-9]|[1-4]\\d|5[0-2]|99)(00[1-9]|0[1-9]\\d|[1-9]\\d\\d)\\d$";
        static readonly Regex re = new Regex(strRegex);
        
        /*
         Regex-ul de mai sus verifica daca cnp-ul are formatul si lungimea corecta
         In metoda IsValidCnp, dupa ce sparg cnp-ul in cifre folosesc formula pentru cifra de control a cnp-ul
         Restul impartirii calculului la 11 trebuie sa fie egal cu ultima cifra a cnp-ului(cifra de control)
         Daca restul este 10 atunci cComponent devine 1
         Source: wikipedia
         */

        public static bool IsValidCnp(string cnp)
        {
            ArrayList cnpList = new ArrayList();

            for (int i = 0; i <= 12; i++)
                cnpList.Add(int.Parse(cnp[i].ToString()));

            /*
             Ultima cifra a cnp-ului calculata cu formula de pe wikipedia pentru a verifica daca este valid
             */
            int cComponent = Convert.ToInt32(cnpList[0]) * 2 + Convert.ToInt32(cnpList[1]) * 7 + Convert.ToInt32(cnpList[2]) * 9 + Convert.ToInt32(cnpList[3]) + Convert.ToInt32(cnpList[4]) * 4 + Convert.ToInt32(cnpList[5]) * 6 + Convert.ToInt32(cnpList[6]) * 3
                    + Convert.ToInt32(cnpList[7]) * 5 + Convert.ToInt32(cnpList[8]) * 8 + Convert.ToInt32(cnpList[9]) * 2 + Convert.ToInt32(cnpList[10]) * 7 + Convert.ToInt32(cnpList[11]) * 9;

            cComponent %= 11;

            if (cComponent == 10)
                cComponent = 1;

            if (re.IsMatch(cnp) && cComponent == Convert.ToInt32(cnpList[12]))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

    }
}
