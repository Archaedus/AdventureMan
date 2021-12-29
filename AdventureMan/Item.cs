using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class Item
    {

        #region Item Attributes

        public double itemWeight = 0;
        public int itemValue = 0;
        public int itemHealth = 0;
        public double itemSize = 0;
        // Item uses remaining int?

        public string itemName = "";
        public string itemDescription = "";
        

        #endregion

        public Item(string aItemName) 
        {
            ItemCreator(aItemName);
        }

        public void ItemCreator(string aItemName) 
        {
            if (aItemName.ToUpper() == ItemAttributeList.healthPotionSName.ToUpper())
            {
                itemName = ItemAttributeList.healthPotionSName;
                itemDescription = ItemAttributeList.healthPotionSDescription;

                itemWeight = ItemAttributeList.healthPotionSWeight;
                itemValue = ItemAttributeList.healthPotionSValue;
                itemHealth = ItemAttributeList.healthPotionSHealth;
                itemSize = ItemAttributeList.healthPotionSSize;

            }
            else if (aItemName.ToUpper() == ItemAttributeList.healthPotionMName.ToUpper())
            {
                itemName = ItemAttributeList.healthPotionMName;
                itemDescription = ItemAttributeList.healthPotionMDescription;

                itemWeight = ItemAttributeList.healthPotionMWeight;
                itemValue = ItemAttributeList.healthPotionMValue;
                itemHealth = ItemAttributeList.healthPotionMHealth;
                itemSize = ItemAttributeList.healthPotionMSize;
            }
            else if (aItemName.ToUpper() == ItemAttributeList.healthPotionLName.ToUpper())
            {
                itemName = ItemAttributeList.healthPotionLName;
                itemDescription = ItemAttributeList.healthPotionLDescription;

                itemWeight = ItemAttributeList.healthPotionLWeight;
                itemValue = ItemAttributeList.healthPotionLValue;
                itemHealth = ItemAttributeList.healthPotionLHealth;
                itemSize = ItemAttributeList.healthPotionLSize;
            }
            else if (aItemName.ToUpper() == ItemAttributeList.fatiguePotionSName.ToUpper())
            {
                itemName = ItemAttributeList.fatiguePotionSName;
                itemDescription = ItemAttributeList.fatiguePotionSDescription;

                itemWeight = ItemAttributeList.fatiguePotionSWeight;
                itemValue = ItemAttributeList.fatiguePotionSValue;
                itemHealth = ItemAttributeList.fatiguePotionSHealth;
                itemSize = ItemAttributeList.fatiguePotionSSize;
            }
            else if (aItemName.ToUpper() == ItemAttributeList.fatiguePotionMName.ToUpper())
            {
                itemName = ItemAttributeList.fatiguePotionMName;
                itemDescription = ItemAttributeList.fatiguePotionMDescription;

                itemWeight = ItemAttributeList.fatiguePotionMWeight;
                itemValue = ItemAttributeList.fatiguePotionMValue;
                itemHealth = ItemAttributeList.fatiguePotionMHealth;
                itemSize = ItemAttributeList.fatiguePotionMSize;
            }
            else if (aItemName.ToUpper() == ItemAttributeList.fatiguePotionLName.ToUpper())
            {
                itemName = ItemAttributeList.fatiguePotionLName;
                itemDescription = ItemAttributeList.fatiguePotionLDescription;

                itemWeight = ItemAttributeList.fatiguePotionLWeight;
                itemValue = ItemAttributeList.fatiguePotionLValue;
                itemHealth = ItemAttributeList.fatiguePotionLHealth;
                itemSize = ItemAttributeList.fatiguePotionLSize;
            }
            else 
            {
                Console.WriteLine("\nThis is a null item."); // This happons if somehow nothing matches

                Thread.Sleep(1000);

                Console.Clear();
            }
        }      
    }
}
