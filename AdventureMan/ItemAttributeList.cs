using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal static class ItemAttributeList
    {
        #region Useable Item List And Attributes

        public static string[] usableItemNameList = { "Small Health Potion", "Medium Health Potion", "Large Health Potion", "Small Fatigue Potion", "Medium Fatigue Potion", "Large Fatigue Potion" };

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

        #region Equipable Item List And Attributes

        #region Held Items and Weapons

        public static string[] equipableWeaponNameList = { "Longsword" };

        #region Longsword

        public static string longswordName = "Longsword";

        public static double longswordWeight = 3.5;
        public static int longswordValue = 135;
        public static int longswordHealth = 50;
        public static string longswordDescription = "A hand and a half sword used by nobles and footmen alike. The weapon of kings and knights.";
        public static double longswordSize = 3;

        public static string longswordDamage = "1d8";
        public static bool longswordCanBeOneHanded = true;
        public static bool longswordCanBeTwoHanded = true;

        #endregion

        #endregion

        #region Armor

        public static string[] equipableArmorNameList = { "Breastplate", "Steel Boots" };

        #region Breastplate

        public static string breastplateName = "Breastplate";

        public static int breastplateWeight = 20;
        public static int breastplateValue = 500;
        public static int breastplateHealth = 100;
        public static string breastplateDescription = "A form fitted sheet of metal protecting the torso of whomever dons it.";
        public static double breastplateSize = 20;

        public static int breastplateArmorClass = 3;
        public static int breastplateDamageResistance = 3;
        public static string[] breastplateArmorSlot = { "3", "Body" };
        public static int breastplateDexPenalty = 2;

        #endregion

        #region Steel Boots

        public static string steelBootsName = "Steel Boots";

        public static int steelBootsWeight = 7;
        public static int steelBootsValue = 150;
        public static int steelBootsHealth = 100;
        public static string steelBootsDescription = "A set of hearty leather boots with steel plating for extra protection. A bit heavy though.";
        public static double steelBootsSize = 7;

        public static int steelBootsArmorClass = 1;
        public static int steelBootsDamageResistance = 1;
        public static string[] steelBootsArmorSlot = { "4", "Feet" };
        public static int steelBootsDexPenalty = 1; 

        #endregion

        #endregion

        #endregion

        public static void DisplayItemAttributes(string itemName) 
        {
            #region Useable Items

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

            #endregion

            #region Weapons

            else if (itemName.ToUpper() == "LONGSWORD")
            {
                Console.Clear();

                Console.WriteLine($"{longswordName} : {longswordDescription}");
                Console.WriteLine($"\nValue : {longswordValue}  Weight : {longswordWeight}  Object Health : {longswordHealth}   Inventory Size : {longswordSize}" +
                    $"\nWeapon Damage : {longswordDamage}   1h : {longswordCanBeOneHanded}  2h : {longswordCanBeTwoHanded}");
            }

            #endregion

            #region Armor

            else if (itemName.ToUpper() == "BREASTPLATE")
            {
                Console.Clear();

                Console.WriteLine($"{breastplateName} : {breastplateDescription}");
                Console.WriteLine($"\nValue : {breastplateValue}  Weight : {breastplateWeight}  Object Health : {breastplateHealth}   Inventory Size : {breastplateSize}" +
                    $"\nArmor Class Added : {breastplateArmorClass} Damage Resistance Added : {breastplateDamageResistance} Equipment Slot : {breastplateArmorSlot[1]}" +
                    $"\nDex Penalty : {breastplateDexPenalty}");
            }

            else if (itemName.ToUpper() == "STEEL BOOTS") 
            {
                Console.Clear();

                Console.WriteLine($"{steelBootsName} : {steelBootsDescription}");
                Console.WriteLine($"\nValue : {steelBootsValue}  Weight : {steelBootsWeight}  Object Health : {steelBootsHealth}   Inventory Size : {steelBootsSize}" +
                    $"\nArmor Class Added : {steelBootsArmorClass} Damage Resistance Added : {steelBootsDamageResistance} Equipment Slot : {steelBootsArmorSlot[1]}" +
                    $"\nDex Penalty : {steelBootsDexPenalty}");
            }

            #endregion

            else
            {
                Console.Clear();

                Console.WriteLine("This is not a valid item.");

                Thread.Sleep(500);
            }
        }
    }
}
