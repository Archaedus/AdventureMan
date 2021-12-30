using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class CharacterClasses
    {
        public static string[] classList = { "Fighter" };

        // Fighter

        #region Fighter Class Statistics

        public static int fighterHitDie = 10;
        public static int fighterFatigueDie = 10;
        public static int fighterAttackBonus = 1;
        public static int fighterFortitudeSaveBonus = 3;
        public static int fighterReflexSaveBonus = 0;
        public static int fighterWillSaveBonus = 1; 

        #endregion

        // TBD More Classes

        public static int[] ClassLevelUpStats(string charClass) 
        {
            if (charClass.ToUpper() == "FIGHTER")
            {
                int[] fighterClassValues = { fighterHitDie, fighterFatigueDie, fighterAttackBonus, fighterFortitudeSaveBonus, fighterReflexSaveBonus, fighterWillSaveBonus };

                return fighterClassValues;
            }
            else 
            {
                return null;
            }
        }

        public static void DisplayClassInformation(string charClass) 
        {
            Console.Clear();

            if (charClass.ToUpper() == "FIGHTER")
            {
                Console.WriteLine($"The {classList[0]}'s class information is as follows.");

                Console.WriteLine("\nHit Die : " + fighterHitDie + 
                    "\nFatigue Die : " + fighterFatigueDie + 
                    "\nAttack Bonus : +" + fighterAttackBonus + " per level " + 
                    "\nFortitude Save Bonus : " + fighterFortitudeSaveBonus + 
                    "\nReflex Save Bonus : " + fighterReflexSaveBonus + 
                    "\nWill Save Bonus : " + fighterWillSaveBonus);
            }
            else 
            {
                Console.WriteLine("An invalid class has been passed to the method DisplayClassInformation. Fix me.");

                Thread.Sleep(1000);

                Environment.Exit(0);
            }
        }
    }
}
