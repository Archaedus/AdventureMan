using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class Battle
    {   
        public static void OneOnOneBattleLoop(Character playerCharacter, Character enemyCharacter) 
        {
            Console.WriteLine($"You have been engaged in battle by a {enemyCharacter.charName}!");

            Thread.Sleep(1000);
            
            while (playerCharacter.charCurrHP > 0 || enemyCharacter.charCurrHP > 0) 
            {
                Console.Clear();
                
                DisplayCharacterBattleInformation(playerCharacter);
                Console.WriteLine();
                DisplayEnemyInformation(enemyCharacter);

                Console.WriteLine("\nAttack, Defend");

                // Need semblance of both turn order and whatever a turn is... maybe just a flag that resets at the beginning of the loop? The overarching battle is controlled by hp while this loop is concerned with who has taken their turns
            }
        }
        public static string[] CreateAdversary(string enemy) 
        {
            string[] enemyAttributesArray = new string[13];
            
            if (enemy.ToUpper() == "BANDIT")
            {
                enemyAttributesArray = EnemyList.banditAttributes;
            }
            else 
            {
                Console.WriteLine("Invalid enemy selection. Terminating program. Fix me.");
                Console.ReadLine();

                Environment.Exit(0);
            }

            return enemyAttributesArray;
        }
        public static void DisplayCharacterBattleInformation(Character playerCharacter) 
        {
            Console.WriteLine($"\nPlayer Name : " + playerCharacter.charName);

            Console.WriteLine("HP : " + playerCharacter.charCurrHP + " / " + playerCharacter.charTotalMaxHP + "    Fatigue : " + playerCharacter.charCurrFatigue + " / " + playerCharacter.charTotalMaxFatigue);

            Console.WriteLine("\nAttack Bonus : " + playerCharacter.charTotalAttackBonus);
            Console.WriteLine($"{playerCharacter.DisplayWeaponHandedness(0)} : {playerCharacter.charWeaponDamage} + {playerCharacter.charTotalDamageBonus}");
            Console.WriteLine($"Armor Class : {playerCharacter.charTotalArmorClass}     Damage Resistance : {playerCharacter.charTotalDamageResistance}     Armor Dex Penality : {playerCharacter.charArmorDexPenalty * -1}");
        }

        public static void DisplayEnemyInformation(Character enemyCharacter) 
        {
            if (enemyCharacter.charCurrHP >= enemyCharacter.charMaxHP * 0.75)
            {
                Console.WriteLine($"{enemyCharacter.charName} is in good health.");
            }
            else if (enemyCharacter.charCurrHP >= enemyCharacter.charMaxHP * 0.50)
            {
                Console.WriteLine($"{enemyCharacter.charName} is beginning to look injured.");
            }
            else if (enemyCharacter.charCurrHP >= enemyCharacter.charMaxHP * 0.25)
            {
                Console.WriteLine($"{enemyCharacter.charName} is looking rather injured.");
            }
            else if (enemyCharacter.charCurrHP >= enemyCharacter.charMaxHP * 0.05)
            {
                Console.WriteLine($"{enemyCharacter.charName} is barely standing.");
            }
            else 
            {
                Console.WriteLine($"{enemyCharacter.charName} is on death's door.");
            }
        }
    }
}
