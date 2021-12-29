using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal static class ItemAttributeList
    {
        public static string[] itemNameList = { "Small Health Potion", "Medium Health Potion", "Large Health Potion", "Small Fatigue Potion", "Medium Fatigue Potion", "Large Fatigue Potion" };
        
        #region Item List And Attributes

        #region Small Health Potion

        public static string healthPotionSName = "Small Health Potion";

        public static double healthPotionSWeight = .1;
        public static int healthPotionSValue = 10;
        public static int healthPotionSHealth = 1;
        public static string healthPotionSDescription = "A small health potion. Recovers 10 HP.";
        public static double healthPotionSSize = .2;

        #endregion

        #region Medium Health Potion

        public static string healthPotionMName = "Medium Health Potion";

        public static double healthPotionMWeight = .75;
        public static int healthPotionMValue = 100;
        public static int healthPotionMHealth = 1;
        public static string healthPotionMDescription = "A medium health potion. Recovers 50 HP.";
        public static double healthPotionMSize = .5;

        #endregion

        #region Large Health Potion

        public static string healthPotionLName = "Large Health Potion";

        public static double healthPotionLWeight = 1.5;
        public static int healthPotionLValue = 750;
        public static int healthPotionLHealth = 1;
        public static string healthPotionLDescription = "A large health potion. Recovers 175 HP.";
        public static double healthPotionLSize = 1;

        #endregion

        #region Small Fatigue Potion

        public static string fatiguePotionSName = "Small Fatigue Potion";

        public static double fatiguePotionSWeight = .1;
        public static int fatiguePotionSValue = 10;
        public static int fatiguePotionSHealth = 1;
        public static string fatiguePotionSDescription = "A small fatigue potion. Recovers 10 fatigue.";
        public static double fatiguePotionSSize = .1;

        #endregion

        #region Medium Fatigue Potion

        public static string fatiguePotionMName = "Medium Fatigue Potion";

        public static double fatiguePotionMWeight = .75;
        public static int fatiguePotionMValue = 100;
        public static int fatiguePotionMHealth = 1;
        public static string fatiguePotionMDescription = "A medium fatigue potion. Recovers 50 fatigue.";
        public static double fatiguePotionMSize = .5;

        #endregion

        #region Large Fatigue Potion

        public static string fatiguePotionLName = "Large Fatigue Potion";

        public static double fatiguePotionLWeight = 1.5;
        public static int fatiguePotionLValue = 750;
        public static int fatiguePotionLHealth = 1;
        public static string fatiguePotionLDescription = "A large fatigue potion. Recovers 175 fatigue.";
        public static double fatiguePotionLSize = 1;

        #endregion

        #endregion

        public static void DisplayItemAttributes(string itemName) 
        {
            if (itemName.ToUpper() == healthPotionSName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{healthPotionSName} : {healthPotionSDescription}");
                Console.WriteLine($"\nValue : {healthPotionSValue}  Weight : {healthPotionSWeight}  Object Health : {healthPotionSHealth}   Inventory Size : {healthPotionSSize}");
            }
            else if (itemName.ToUpper() == healthPotionMName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{healthPotionMName} : {healthPotionMDescription}");
                Console.WriteLine($"\nValue : {healthPotionMValue}  Weight : {healthPotionMWeight}  Object Health : {healthPotionMHealth}   Inventory Size : {healthPotionMSize}");
            }
            else if (itemName.ToUpper() == healthPotionLName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{healthPotionLName} : {healthPotionLDescription}");
                Console.WriteLine($"\nValue : {healthPotionLValue}  Weight : {healthPotionLWeight}  Object Health : {healthPotionLHealth}   Inventory Size : {healthPotionLSize}");
            }
            else if (itemName.ToUpper() == fatiguePotionSName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{fatiguePotionSName} : {fatiguePotionSDescription}");
                Console.WriteLine($"\nValue : {fatiguePotionSValue}  Weight : {fatiguePotionSWeight}  Object Health : {fatiguePotionSHealth}   Inventory Size : {fatiguePotionSSize}");
            }
            else if (itemName.ToUpper() == fatiguePotionMName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{fatiguePotionMName} : {fatiguePotionMDescription}");
                Console.WriteLine($"\nValue : {fatiguePotionMValue}  Weight : {fatiguePotionMWeight}  Object Health : {fatiguePotionMHealth}   Inventory Size : {fatiguePotionMSize}");
            }
            else if (itemName.ToUpper() == fatiguePotionLName.ToUpper())
            {
                Console.Clear();

                Console.WriteLine($"{fatiguePotionLName} : {fatiguePotionLDescription}");
                Console.WriteLine($"\nValue : {fatiguePotionLValue}  Weight : {fatiguePotionLWeight}  Object Health : {fatiguePotionLHealth}   Inventory Size : {fatiguePotionLSize}");
            }
            else
            {
                Console.Clear();
                
                Console.WriteLine("This is not a valid item.");

                Thread.Sleep(500);
            }
        }
    }
}
