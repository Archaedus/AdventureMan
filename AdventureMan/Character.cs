using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class Character
    {
        //Fluff Information

        #region Fluff Information

        public string charName;
        public int charHeight;
        public int charWeight;
        public int charAge;
        public string charRace;
        // Gender?

        public string charSize;

        #endregion

        // Main Numerical Attributes

        #region Main Numerical Attributes

        public int charTrueStr; // Attributes with no modifiers
        public int charTrueDex;
        public int charTrueCon;
        public int charTrueInt;
        public int charTrueWis;
        public int charTrueCha;
        public int charTrueCom; // Unused for now

        public int charStrTempAdj = 0; // Penalties and buffs
        public int charDexTempAdj = 0;
        public int charConTempAdj = 0;
        public int charIntTempAdj = 0;
        public int charWisTempAdj = 0;
        public int charChaTempAdj = 0;
        public int charComTempAdj = 0; // Unused for now

        public int charStrCurr; // Effective score
        public int charDexCurr;
        public int charConCurr;
        public int charIntCurr;
        public int charWisCurr;
        public int charChaCurr;
        public int charComCurr; // Unused for now

        #endregion

        // Equipment Slots

        #region Equipment Slots

        public string charHeldSlotR = "Empty";
        public string charHeldSlotL = "Empty";
        public string charHelmSlot = "Empty";
        public string charBodySlot = "Empty";
        public string charArmsSlot = "Empty"; // Going to be unused for now
        public string charLegsSlot = "Empty"; // Going to be unused for now
        public string charFeetSlot = "Empty";
        public string charNeckSlot = "Empty";
        public string charRingSlotL = "Empty";
        public string charRingSlotR = "Empty";

        public string[] charEquipmentLoadOut = { "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty" }; // In order : Right and Left Held Slots, Helm, Body, Feet, Neck, Ring R, Ring L

        public int charBaseArmorClass = 10;
        public int charArmorBonus = 0;
        public int charTotalArmorClass;
        public int charArmorDexPenalty = 0;

        public int charArmorDamageResistance = 0;
        public int charTotalDamageResistance;

        public bool charIsTwoHanding = false;
        public string charBaseFistDamage = "1d2"; // Should be race specific?
        public string charWeaponDamage;

        #endregion

        // Inventory

        #region Inventory

        public string[] charInventory = { "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty" };

        public double inventoryWeight = 0;

        public int charMoneyHeld = 0;

        #endregion

        // Important Miscellaneous Information

        #region Important Miscellaneous Information

        public string charClass;
        public int charLevel = 0;
        public int charCurrentExp = 0;
        public int charExpToNextLevel = 1;

        public bool isPlayerControlled;

        #endregion

        // Derived Attributes

        #region Derived Attributes

        public int charStrBonus; // Standard formula at character creation to be (Attribute - 10)*0.5
        public int charDexBonus;
        public int charConBonus;
        public int charIntBonus;
        public int charWisBonus;
        public int charChaBonus;

        public int charMaxHP = 0;
        public int charMaxFatigue = 0;
        public int charTotalMaxHP = 0; // Formula at creation to be (charClassHitDie + (charLevel)*0.5) + (charConBonus)
        public int charTotalMaxFatigue = 0; //Formula at creation to be (charClassFatigueDie + charLevel) + (charConBonus + (charStrBonus + charDexBonus)*0.5)
        public int charCurrHP = 0;
        public int charCurrFatigue = 0;

        public int charInitiative = 0; // Just equal to charDexBonus right now

        public int charTotalFortitudeSave = 0; // Formula to be (charClassSaveDie+(charLevel/5) + relevant attribute)
        public int charTotalReflexSave = 0;
        public int charTotalWillSave = 0;

        public int charAttackBonus = 0;
        public int charTotalAttackBonus = 0;
        public int charDamageBonus = 0;
        public int charTotalDamageBonus = 0;

        public string charSizeBonus; // Unused 

        #endregion

        public Character(string aCharName, string aCharRace, int aCharHeight, int aCharWeight, int aCharAge, int aCharStr, int aCharDex, int aCharCon, int aCharInt, int aCharWis, int aCharCha, string aCharClass, bool playerControlled) // The order this comes in will be VERY important
        {
            SetFluffAttributes(aCharName, aCharHeight, aCharWeight, aCharAge, aCharRace);
            SetMiscellaneousAttributes(aCharClass);
            SetMainAttributes(aCharStr, aCharDex, aCharCon, aCharInt, aCharWis, aCharCha);
            CharacterLevelUp(aCharClass);
            SetDerivedAttributes(aCharClass);

            isPlayerControlled = playerControlled;

            charCurrHP = charTotalMaxHP;
            charCurrFatigue = charTotalMaxFatigue;
        }

        public void SetMainAttributes(int aCharStr, int aCharDex, int aCharCon, int aCharInt, int aCharWis, int aCharCha)
        {
            charTrueStr = aCharStr;
            charTrueDex = aCharDex;
            charTrueCon = aCharCon;
            charTrueInt = aCharInt;
            charTrueWis = aCharWis;
            charTrueCha = aCharCha;

            charStrCurr = charTrueStr;
            charDexCurr = charTrueDex;
            charConCurr = charTrueCon;
            charIntCurr = charTrueInt;
            charWisCurr = charTrueWis;
            charChaCurr = charTrueCha;
        }

        public void SetMiscellaneousAttributes(string aCharClass)
        {
            charClass = aCharClass;
            charLevel = 0;
            charCurrentExp = 0;
            charExpToNextLevel = 0;
        }

        public void SetDerivedAttributes(string aCharClass) // This is intended to be called whenever a stat change may occur, including in battle, change name to update character?
        {
            // Start of setting bonus derivatives

            charStrCurr = charTrueStr + charStrTempAdj;
            charDexCurr = charTrueDex + charDexTempAdj;
            charConCurr = charTrueCon + charConTempAdj;
            charIntCurr = charTrueInt + charIntTempAdj;
            charWisCurr = charTrueWis + charWisTempAdj;
            charChaCurr = charTrueCha + charChaTempAdj;

            charStrBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charStrCurr - 10) * 0.5)));
            charDexBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charDexCurr - 10) * 0.5)));
            charConBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charConCurr - 10) * 0.5)));
            charIntBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charIntCurr - 10) * 0.5)));
            charWisBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charWisCurr - 10) * 0.5)));
            charChaBonus = Convert.ToInt32(Math.Floor(Convert.ToDouble((charChaCurr - 10) * 0.5)));

            // End of setting bonus derivatives

            // Start of save derivatives

            charTotalFortitudeSave = CharacterClasses.ClassLevelUpStats(aCharClass)[3] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charConBonus; // Can remove the charClass dependency by setting initial saves in CharacterLevelUp method? We already do that when making a character anyway
            charTotalReflexSave = CharacterClasses.ClassLevelUpStats(aCharClass)[4] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charDexBonus;
            charTotalWillSave = CharacterClasses.ClassLevelUpStats(aCharClass)[5] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charWisBonus;

            // End of save derivatives

            // Start of health/fatigue derivatives

            charTotalMaxHP = charMaxHP + charConBonus * charLevel;
            charTotalMaxFatigue = charMaxFatigue + charConBonus + Convert.ToInt32(Math.Floor(Convert.ToDouble((charStrBonus + charDexBonus) / 2) + charLevel * 0.5));

            if (charCurrHP > charTotalMaxHP)
            {
                charCurrHP = charTotalMaxHP;
            }
            if (charCurrFatigue > charTotalMaxFatigue)
            {
                charCurrFatigue = charTotalMaxFatigue;
            }

            // End of health/fatigue derivatives

            // Start of miscellaneous

            charInitiative = charDexBonus;
            charTotalAttackBonus = charAttackBonus + charStrBonus;
            
            charTotalArmorClass = charBaseArmorClass + charArmorBonus + charDexBonus - charArmorDexPenalty;
            charTotalDamageResistance = charArmorDamageResistance;

            if (charEquipmentLoadOut[0].ToUpper() == "EMPTY" && charEquipmentLoadOut[1].ToUpper() == "EMPTY")
            {
                charWeaponDamage = charBaseFistDamage;
                charTotalDamageBonus = charDamageBonus + charStrBonus;
            }
            else if (charIsTwoHanding == true)
            {
                charTotalDamageBonus = charDamageBonus + Convert.ToInt32(Math.Floor(Convert.ToDouble(charStrBonus) * 1.5));
            }
            else 
            {
                charTotalDamageBonus = charDamageBonus + charStrBonus;
            }
            // End of miscellaneous

        }

        public void SetFluffAttributes(string aCharName, int aCharHeight, int aCharWeight, int aCharAge, string aCharRace)
        {
            charName = aCharName;
            charRace = aCharRace;

            charHeight = CharacterRaces.HeightChecker(aCharRace, aCharHeight);
            charWeight = CharacterRaces.WeightChecker(aCharRace, aCharWeight);
            charAge = CharacterRaces.AgeChecker(aCharRace, aCharAge);

            if (charHeight < 165)
            {
                charSize = "Small";
                charWeight = Convert.ToInt32(Convert.ToDouble(charWeight * 0.75));
            }
            else if (charHeight > 180)
            {
                charSize = "Large";
                charWeight = Convert.ToInt32(Convert.ToDouble(charWeight * 1.5));
            }
            else
            {
                charSize = "Medium";
            }
        }
        public void CharacterLevelUp(string charClass)
        {
            charLevel++;
            charExpToNextLevel = charLevel * 1000;

            charMaxHP = charMaxHP + CharacterClasses.ClassLevelUpStats(charClass)[0];
            charMaxFatigue = charMaxFatigue + CharacterClasses.ClassLevelUpStats(charClass)[1];
            charAttackBonus = charAttackBonus + CharacterClasses.ClassLevelUpStats(charClass)[2];

            SetDerivedAttributes(charClass);
        }

        public void DisplayPlayerCharacterInformation()
        {
            Console.Clear();

            Console.WriteLine("CHARACTER INFO");

            Console.WriteLine($"\nPlayer Name : " + charName);
            Console.WriteLine("Race : " + charRace);

            Console.WriteLine("\nHeight(cm) : " + charHeight);
            Console.WriteLine("Weight(lb) : " + charWeight);
            Console.WriteLine("Size : " + charSize);

            Console.WriteLine("\nClass : " + charClass);
            Console.WriteLine("Level : " + charLevel);
            Console.WriteLine("Current EXP : " + charCurrentExp + "    EXP To Next Level : " + charExpToNextLevel);

            Console.WriteLine("\nInitiative Bonus : " + charInitiative);
            Console.WriteLine("HP : " + charCurrHP + " / " + charTotalMaxHP + "    Fatigue : " + charCurrFatigue + " / " + charTotalMaxFatigue);

            Console.WriteLine($"\nSTR : {charTrueStr}   Adj : {UserInputFunctions.ApplyPlusSignMod(charStrTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charStrBonus)}");
            Console.WriteLine($"DEX : {charTrueDex}   Adj : {UserInputFunctions.ApplyPlusSignMod(charDexTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charDexBonus)}");
            Console.WriteLine($"CON : {charTrueCon}   Adj : {UserInputFunctions.ApplyPlusSignMod(charConTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charConBonus)}");
            Console.WriteLine($"INT : {charTrueInt}   Adj : {UserInputFunctions.ApplyPlusSignMod(charIntTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charIntBonus)}");
            Console.WriteLine($"WIS : {charTrueWis}   Adj : {UserInputFunctions.ApplyPlusSignMod(charWisTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charWisBonus)}");
            Console.WriteLine($"CHA : {charTrueCha}   Adj : {UserInputFunctions.ApplyPlusSignMod(charChaTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charChaBonus)}");

            Console.WriteLine("\nAttack Bonus : " + charTotalAttackBonus);
            Console.WriteLine($"{DisplayWeaponHandedness(0)} : {charWeaponDamage} + {charTotalDamageBonus}");
            Console.WriteLine($"Armor Class : {charTotalArmorClass} Damage Resistance : {charTotalDamageResistance}");            

            Console.WriteLine("\nFort Save : " + charTotalFortitudeSave + "    Reflex Save : " + charTotalReflexSave + "    Will Save : " + charTotalWillSave);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public int AutoPickUpValidInventorySlotCheck()
        {
            bool validInventorySpotFlag = false;
            int inventoryPosition = 0;
            int fullInventory = 999;

            try
            {
                while (validInventorySpotFlag == false)
                {
                    if (charInventory[inventoryPosition] == "Empty")
                    {
                        validInventorySpotFlag = true;
                    }
                    else
                    {
                        inventoryPosition++;
                    }
                }

                return inventoryPosition;
            }
            catch (IndexOutOfRangeException)
            {              
                return fullInventory;
            }
        }
        public bool ItemUseBehavior(int slotUsed) 
        {
            bool wasItemUsed = false;

            if (charInventory[slotUsed].ToUpper() == ItemAttributeList.healthPotionSName.ToUpper()) // Small Health Potion
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrHP = charCurrHP + 10;

                    if (charCurrHP > charTotalMaxHP)
                    {
                        charCurrHP = charTotalMaxHP;
                    }
                }

                Console.WriteLine("You used a small health potion. You recover 10 HP.");

                Thread.Sleep(1000);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == ItemAttributeList.healthPotionMName.ToUpper()) // Medium Health Potion
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrHP = charCurrHP + 50;

                    if (charCurrHP > charTotalMaxHP)
                    {
                        charCurrHP = charTotalMaxHP;
                    }
                }

                Console.WriteLine("You used a medium health potion. You recover 50 HP.");

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == ItemAttributeList.healthPotionLName.ToUpper()) // Large Health Potion
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrHP = charCurrHP + 175;

                    if (charCurrHP > charTotalMaxHP)
                    {
                        charCurrHP = charTotalMaxHP;
                    }
                }

                Console.WriteLine("You used a large health potion. You recover 175 HP.");

                Thread.Sleep(1000);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == ItemAttributeList.fatiguePotionSName.ToUpper()) // Small Fatigue Potion
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrFatigue = charCurrFatigue + 10;

                    if (charCurrFatigue > charTotalMaxFatigue)
                    {
                        charCurrFatigue = charTotalMaxFatigue;
                    }
                }

                Console.WriteLine("You used a small fatigue potion. You recover 10 Fatigue.");

                Thread.Sleep(1000);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == ItemAttributeList.fatiguePotionMName.ToUpper()) // Medium Fatigue Potion
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrFatigue = charCurrFatigue + 50;

                    if (charCurrFatigue > charTotalMaxFatigue)
                    {
                        charCurrFatigue = charTotalMaxFatigue;
                    }
                }

                Console.WriteLine("You used a medium fatigue potion. You recover 50 Fatigue.");

                Thread.Sleep(1000);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == ItemAttributeList.fatiguePotionLName.ToUpper()) // Large Fatigue Potion
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(1000);

                    return wasItemUsed;
                }
                else
                {
                    charCurrFatigue = charCurrFatigue + 175;

                    if (charCurrFatigue > charTotalMaxFatigue)
                    {
                        charCurrFatigue = charTotalMaxFatigue;
                    }
                }

                Console.WriteLine("You used a large fatigue potion. You recover 175 Fatigue.");

                Thread.Sleep(1000);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "EMPTY")
            {
                Console.Clear();

                Console.WriteLine("This inventory slot is empty.");

                Thread.Sleep(1000);

                return wasItemUsed = false;
            }
            else 
            {
                Console.Clear();

                Console.WriteLine("You cannot use this item.");

                Thread.Sleep(500);

                return wasItemUsed = false;
            }
        }

        public bool DropItemBehavior(int slotUsed) 
        {
            bool wasItemDropped = false;
            bool itemDropLoopFlag = true;

            while (itemDropLoopFlag == true) 
            {
                Console.Clear();

                Console.Write($"Are you sure you want to drop {charInventory[slotUsed]}? ");

                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                {
                    wasItemDropped = true;
                    itemDropLoopFlag = false;

                    Console.Clear();

                    Console.WriteLine($"Dropping {charInventory[slotUsed]}...");

                    Thread.Sleep(1000);
                }
                else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                {
                    itemDropLoopFlag = false;

                    Console.Clear();

                    Console.WriteLine($"Did not drop {charInventory[slotUsed]}. Returning to inventory selection...");

                    Thread.Sleep(1000);
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"{userInput} is not a valid selection.");

                    Thread.Sleep(1000);
                }
            }       
            return wasItemDropped;
        }

        public void DisplayEquipmentSlots() 
        {
            Console.WriteLine("Equipment Loadout :");
            
            Console.WriteLine($"\nRight Hand : {charEquipmentLoadOut[0]}" +
                $"\nLeft Hand : {DisplayWeaponHandedness(1)}" +
                $"\n\nHelm : {charEquipmentLoadOut[2]}" +
                $"\nBody : {charEquipmentLoadOut[3]}" +
                $"\nFeet : {charEquipmentLoadOut[4]}" +
                $"\nNeck : {charEquipmentLoadOut[5]}" +
                $"\nRing R : {charEquipmentLoadOut[6]}" +
                $"\nRing L : {charEquipmentLoadOut[7]}");
        }

        public void DisplayInventorySlots() 
        {
            int inventoryPosition = 1;

            Console.WriteLine("\nInventory Slots :\n");

            foreach (string slot in charInventory)
            {
                Console.WriteLine("Slot " + inventoryPosition + " : " + slot);

                inventoryPosition++;
            }
        }

        public string DisplayWeaponHandedness(int equipmentSlot) // Specifically to display whether or not character is 2handing weapon in DisplayCharacterInformation and DisplayEquipmentSlots
        {
            string weaponDisplay;
            
            if (charIsTwoHanding == true)
            {
                weaponDisplay = $"{charEquipmentLoadOut[equipmentSlot]} 2H";
            }
            else 
            {
                weaponDisplay = $"{charEquipmentLoadOut[equipmentSlot]}";
            }

            return weaponDisplay;
        }

        public bool UnEquipUseBehavior(int slotUsed) 
        {
            bool wasItemUnEquipped = false;

            int freeInventorySlot = AutoPickUpValidInventorySlotCheck();

            #region Armor Equipment Behavior

            if (charEquipmentLoadOut[slotUsed].ToUpper() == ItemAttributeList.breastplateName.ToUpper()) // Breastplate
            {
                if (freeInventorySlot != 999)
                {
                    wasItemUnEquipped = true;

                    charInventory[freeInventorySlot] = charEquipmentLoadOut[slotUsed];

                    charArmorBonus = charArmorBonus - ItemAttributeList.breastplateArmorClass;
                    charArmorDamageResistance = charArmorDamageResistance - ItemAttributeList.breastplateDamageResistance;
                    charArmorDexPenalty = charArmorDexPenalty - ItemAttributeList.breastplateDexPenalty;

                    Console.Clear();

                    Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and placed in inventory slot {freeInventorySlot + 1}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    bool yesOrNoLoopFlag = true;

                    while (yesOrNoLoopFlag == true)
                    {
                        Console.Clear();

                        Console.Write($"You have no available inventory slots. Unequip {charEquipmentLoadOut[slotUsed]} anyway? (This will destroy the item) ");

                        string userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            wasItemUnEquipped = true;
                            yesOrNoLoopFlag = false;

                            charArmorBonus = charArmorBonus - ItemAttributeList.breastplateArmorClass;
                            charArmorDamageResistance = charArmorDamageResistance - ItemAttributeList.breastplateDamageResistance;
                            charArmorDexPenalty = charArmorDexPenalty - ItemAttributeList.breastplateDexPenalty;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and thrown away.");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} remains equipped. Returning to inventory...");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            else if (charEquipmentLoadOut[slotUsed].ToUpper() == ItemAttributeList.steelBootsName.ToUpper()) // Steel Boots
            {
                if (freeInventorySlot != 999)
                {
                    wasItemUnEquipped = true;

                    charInventory[freeInventorySlot] = charEquipmentLoadOut[slotUsed];

                    charArmorBonus = charArmorBonus - ItemAttributeList.steelBootsArmorClass;
                    charArmorDamageResistance = charArmorDamageResistance - ItemAttributeList.steelBootsDamageResistance;
                    charArmorDexPenalty = charArmorDexPenalty - ItemAttributeList.steelBootsDexPenalty;

                    Console.Clear();

                    Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and placed in inventory slot {freeInventorySlot + 1}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    bool yesOrNoLoopFlag = true;

                    while (yesOrNoLoopFlag == true)
                    {
                        Console.Clear();

                        Console.Write($"You have no available inventory slots. Unequip {charEquipmentLoadOut[slotUsed]} anyway? (This will destroy the item) ");

                        string userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            wasItemUnEquipped = true;
                            yesOrNoLoopFlag = false;

                            charArmorBonus = charArmorBonus - ItemAttributeList.steelBootsArmorClass;
                            charArmorDamageResistance = charArmorDamageResistance - ItemAttributeList.steelBootsDamageResistance;
                            charArmorDexPenalty = charArmorDexPenalty - ItemAttributeList.steelBootsDexPenalty;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and thrown away.");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} remains equipped. Returning to inventory...");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    }
                }
            }

            #endregion

            #region Weapons and Held Items

            else if (charEquipmentLoadOut[slotUsed].ToUpper() == ItemAttributeList.longswordName.ToUpper()) // Longsword 
            {
                if (freeInventorySlot != 999)
                {
                    wasItemUnEquipped = true;

                    charInventory[freeInventorySlot] = charEquipmentLoadOut[slotUsed];

                    charWeaponDamage = charBaseFistDamage;

                    Console.Clear();

                    Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and placed in inventory slot {freeInventorySlot + 1}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    bool yesOrNoLoopFlag = true;

                    while (yesOrNoLoopFlag == true)
                    {
                        Console.Clear();

                        Console.Write($"You have no available inventory slots. Unequip {charEquipmentLoadOut[slotUsed]} anyway? (This will destroy the item) ");

                        string userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            wasItemUnEquipped = true;
                            yesOrNoLoopFlag = false;

                            charWeaponDamage = charBaseFistDamage;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and thrown away.");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} remains equipped. Returning to inventory...");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            
            #endregion

            return wasItemUnEquipped;
        }

        public bool EquipUseBehavior(int slotUsed) 
        {
            bool wasItemEquipped = false;

            string[] armorAttributes = ItemAttributeList.GetArmorAttributes(charInventory[slotUsed]);
            string[] weaponAttributes = ItemAttributeList.GetWeaponAttributes(charInventory[slotUsed]);

            if (armorAttributes != null)
            {
                if (charEquipmentLoadOut[Convert.ToInt32(armorAttributes[2])].ToUpper() == "EMPTY")
                {
                    wasItemEquipped = true;

                    charEquipmentLoadOut[Convert.ToInt32(armorAttributes[2])] = charInventory[slotUsed];
                    charArmorBonus = charArmorBonus + Convert.ToInt32(armorAttributes[0]);
                    charArmorDamageResistance = charArmorDamageResistance + Convert.ToInt32(armorAttributes[1]);
                    charArmorDexPenalty = charArmorDexPenalty + Convert.ToInt32(armorAttributes[4]);

                    Console.Clear();

                    Console.WriteLine($"You have equipped the {charInventory[slotUsed]} to your {armorAttributes[3]}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"Could not equip {charInventory[slotUsed]} since that equipment slot is taken by {charEquipmentLoadOut[Convert.ToInt32(armorAttributes[2])]}");

                    Thread.Sleep(1000);
                }
            }
            else if (weaponAttributes != null)
            {    
                if (charEquipmentLoadOut[0].ToUpper() == "EMPTY")
                {
                    if (Convert.ToBoolean(weaponAttributes[1]) == true && Convert.ToBoolean(weaponAttributes[2]) == true) // Checking to see if the weapon can be wielded in both 1h and 2h mode
                    {
                        bool oneHandOrTwoHandLoop = true;

                        do
                        {
                            Console.Clear();

                            Console.Write("Equip 1h or 2h? ");

                            string userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "1" || userInput.ToUpper() == "1H" || userInput.ToUpper() == "ONE HANDED" || userInput.ToUpper() == "ONEHANDED")
                            {
                                oneHandOrTwoHandLoop = false;
                                wasItemEquipped = true;

                                charEquipmentLoadOut[0] = charInventory[slotUsed];
                                charIsTwoHanding = false;

                                charWeaponDamage = weaponAttributes[0];

                                Console.Clear();

                                Console.WriteLine($"You have equipped the {charInventory[slotUsed]} in one hand.");

                                Thread.Sleep(1000);

                            }
                            else if (userInput.ToUpper() == "2" || userInput.ToUpper() == "2H" || userInput.ToUpper() == "TWO HANDED" || userInput.ToUpper() == "TWOHANDED")
                            {
                                if (charEquipmentLoadOut[0].ToUpper() == "EMPTY" && charEquipmentLoadOut[1].ToUpper() == "EMPTY")
                                {
                                    oneHandOrTwoHandLoop = false;
                                    wasItemEquipped = true;

                                    charEquipmentLoadOut[0] = charInventory[slotUsed];
                                    charEquipmentLoadOut[1] = charInventory[slotUsed];
                                    charIsTwoHanding = true;

                                    charWeaponDamage = weaponAttributes[0];

                                    Console.Clear();

                                    Console.WriteLine($"You have equipped the {charInventory[slotUsed]} in both hands.");

                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    oneHandOrTwoHandLoop = false;

                                    Console.Clear();

                                    Console.WriteLine($"You cannot two hand the {charInventory[slotUsed]} as you do not have two hands free.");

                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine($"You must select to use {charInventory[slotUsed]} with 1h or 2h.");

                                Thread.Sleep(1000);
                            }
                        } while (oneHandOrTwoHandLoop == true);
                    }
                    else if (Convert.ToBoolean(weaponAttributes[1]) == false && Convert.ToBoolean(weaponAttributes[2]) == true) // Checking to see if weapon can only be 2h
                    {
                        if (charEquipmentLoadOut[0].ToUpper() == "EMPTY" && charEquipmentLoadOut[1].ToUpper() == "EMPTY")
                        {
                            wasItemEquipped = true;

                            charEquipmentLoadOut[0] = charInventory[slotUsed];
                            charEquipmentLoadOut[1] = charInventory[slotUsed];
                            charIsTwoHanding = true;

                            charWeaponDamage = weaponAttributes[0];

                            Console.Clear();

                            Console.WriteLine($"You have equipped the {charInventory[slotUsed]} in both hands.");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"You cannot equip the {charInventory[slotUsed]} as you do not have two hands free.");

                            Thread.Sleep(1000);
                        }
                    }
                    else // One handed only
                    {
                        wasItemEquipped = true;

                        charEquipmentLoadOut[0] = charInventory[slotUsed];
                        charIsTwoHanding = false;

                        charWeaponDamage = weaponAttributes[0];

                        Console.Clear();

                        Console.WriteLine($"You have equipped the {charInventory[slotUsed]} in one hand.");

                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"Could not equip {charInventory[slotUsed]} since you already have {charEquipmentLoadOut[0]} equipped.");

                    Thread.Sleep(1000);
                }
            
            }
            else 
            {
                Console.Clear();

                Console.WriteLine($"{charInventory[slotUsed]} is not an equippable item.");

                Thread.Sleep(1000);
            }

            return wasItemEquipped;
        }

        public bool UnEquipUseBehavior2(int slotUsed) 
        {
            bool wasItemUnEquipped = false;

            int freeInventorySlot = AutoPickUpValidInventorySlotCheck();

            string[] armorAttributes = ItemAttributeList.GetArmorAttributes(charEquipmentLoadOut[slotUsed]);
            string[] weaponAttributes = ItemAttributeList.GetWeaponAttributes(charEquipmentLoadOut[slotUsed]);

            if (armorAttributes != null)
            {
                if (freeInventorySlot != 999)
                {
                    wasItemUnEquipped = true;

                    charInventory[freeInventorySlot] = charEquipmentLoadOut[slotUsed];

                    charArmorBonus = charArmorBonus - Convert.ToInt32(armorAttributes[0]);
                    charArmorDamageResistance = charArmorDamageResistance - Convert.ToInt32(armorAttributes[1]);
                    charArmorDexPenalty = charArmorDexPenalty - Convert.ToInt32(armorAttributes[4]);

                    Console.Clear();

                    Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and placed in inventory slot {freeInventorySlot + 1}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    bool yesOrNoLoopFlag = true;

                    while (yesOrNoLoopFlag == true)
                    {
                        Console.Clear();

                        Console.Write($"You have no available inventory slots. Unequip {charEquipmentLoadOut[slotUsed]} anyway? (This will destroy the item) ");

                        string userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            wasItemUnEquipped = true;
                            yesOrNoLoopFlag = false;

                            charArmorBonus = charArmorBonus - Convert.ToInt32(armorAttributes[0]);
                            charArmorDamageResistance = charArmorDamageResistance - Convert.ToInt32(armorAttributes[1]);
                            charArmorDexPenalty = charArmorDexPenalty - Convert.ToInt32(armorAttributes[4]);

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and thrown away.");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} remains equipped. Returning to inventory...");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            else if (weaponAttributes != null)
            {
                if (freeInventorySlot != 999)
                {
                    wasItemUnEquipped = true;

                    charInventory[freeInventorySlot] = charEquipmentLoadOut[slotUsed];

                    charWeaponDamage = charBaseFistDamage;

                    Console.Clear();

                    Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and placed in inventory slot {freeInventorySlot + 1}.");

                    Thread.Sleep(1000);
                }
                else
                {
                    bool yesOrNoLoopFlag = true;

                    while (yesOrNoLoopFlag == true)
                    {
                        Console.Clear();

                        Console.Write($"You have no available inventory slots. Unequip {charEquipmentLoadOut[slotUsed]} anyway? (This will destroy the item) ");

                        string userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            wasItemUnEquipped = true;
                            yesOrNoLoopFlag = false;

                            charWeaponDamage = charBaseFistDamage;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} has been unequipped and thrown away.");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"{charEquipmentLoadOut[slotUsed]} remains equipped. Returning to inventory...");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            else 
            {
                Console.Clear();

                Console.WriteLine("Cannot unequip this invalid item. Please report me.");

                Thread.Sleep(1000);
            }

            return wasItemUnEquipped;
        }
    }
}
