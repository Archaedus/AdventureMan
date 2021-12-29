using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
