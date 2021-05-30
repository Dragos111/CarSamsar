using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSamsar
{
    public class CheckInputs
    {
        public static bool CheckUsernamePassword(string input)
        {
            if (input.Length > 20)
            {
                return false;
            }

            return true;
        }

        public static bool CheckIfDigit(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}
