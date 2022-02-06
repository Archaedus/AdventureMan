using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMan
{
    internal static class CommonEvents
    {
        public static int RollDice(string diceInput) // Input with be in ?d? format, so we'll need to separate it based on that terminator, need to learn how to do, also needs to return an int
        {
            Random randomSeed = new Random();
            
            string[] diceArray = diceInput.Split("d");

            int lNumber = Convert.ToInt32(diceArray[0]);
            int rNumber = Convert.ToInt32(diceArray[1]) + 1; // Here because the Next feature only goes between the two values without including the original value

            int totalResult = 0;

            for (int loops = 0; loops < lNumber; loops++) 
            {
                int roll = randomSeed.Next(1, rNumber);

                Console.WriteLine($"Rolled {roll}");

                totalResult = totalResult + roll;
            }

            return totalResult;
        }

        public static void RollTest()
        {
            Console.WriteLine("Roll testing suite activate");

            string[] diceRollingArray = { "1d8", "2d8", "10d6", "20d4", "100d2", "3d6", "2d6", "3d10" };

            for (int loops = 0; loops < diceRollingArray.Length; loops++)
            {
                Console.WriteLine($"Rolling {diceRollingArray[loops]}...");

                int roll = CommonEvents.RollDice(diceRollingArray[loops]);

                Console.WriteLine($"\nRoll was {roll}... Press any key to continue with the next roll");

                Console.ReadKey();
            }

            Console.WriteLine("Rolling set finished, ending program.");
        }
        
        public static void CalculateDamage() // Probably going into the battle class once I get it running
        { 
            // TODO
        }
    }
}
