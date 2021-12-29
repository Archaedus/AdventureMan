using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class UserInputFunctions
    {
        public static void ListAllElements(string[] aArray)
        {
            foreach (string element in aArray)
            {
                Console.WriteLine(element);
            }
        }

        public static string ApplyPlusSignMod(int aNumber)
        {
            int number = aNumber;
            string finalResult;

            if (number > 0)
            {
                finalResult = $"+{Convert.ToString(number)}";

                return finalResult;
            }
            else
            {
                finalResult = $"{Convert.ToString(number)}";

                return finalResult;
            }
        }
    }    
}
