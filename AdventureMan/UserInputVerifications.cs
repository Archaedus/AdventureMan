using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMan
{
    internal static class UserInputVerifications
    {       
        public static bool IsNumber (string aString)
        {
            int result;
            bool isNumber = int.TryParse(aString, out result);

            if (isNumber == false)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
