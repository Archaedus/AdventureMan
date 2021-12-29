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

        public string charHeldSlotL = "Empty";
        public string charHeldSlotR = "Empty";
        public string charHelmSlot = "Empty";
        public string charBodySlot = "Empty";
        public string charArmsSlot = "Empty";
        public string charLegsSlot = "Empty";
        public string charFeetSlot = "Empty";
        public string charNeckSlot = "Empty";
        public string charRingSlotL = "Empty";
        public string charRingSlotR = "Empty";

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

        public void SetDerivedAttributes(string aCharClass) // This is intended to be called whenever a stat change may occur, including in battle
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

            charTotalFortitudeSave = CharacterClasses.ClassLevelUpStats(aCharClass)[3] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charConBonus;
            charTotalReflexSave = CharacterClasses.ClassLevelUpStats(aCharClass)[4] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charDexBonus;
            charTotalWillSave = CharacterClasses.ClassLevelUpStats(aCharClass)[5] + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(charLevel / 5))) + charWisBonus;

            // End of save derivatives

            // Start of health/fatigue derivatives

            charTotalMaxHP = charMaxHP + charConBonus + Convert.ToInt32(Math.Floor(Convert.ToDouble(charLevel * 0.5)));
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
            charTotalDamageBonus = charDamageBonus + charStrBonus;

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

            Console.WriteLine("\nHP : " + charCurrHP + " / " + charTotalMaxHP + "    Fatigue : " + charCurrFatigue + " / " + charTotalMaxFatigue);

            Console.WriteLine($"\nSTR : {charTrueStr}   Adj : {UserInputFunctions.ApplyPlusSignMod(charStrTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charStrBonus)}");
            Console.WriteLine($"DEX : {charTrueDex}   Adj : {UserInputFunctions.ApplyPlusSignMod(charDexTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charDexBonus)}");
            Console.WriteLine($"CON : {charTrueCon}   Adj : {UserInputFunctions.ApplyPlusSignMod(charConTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charConBonus)}");
            Console.WriteLine($"INT : {charTrueInt}   Adj : {UserInputFunctions.ApplyPlusSignMod(charIntTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charIntBonus)}");
            Console.WriteLine($"WIS : {charTrueWis}   Adj : {UserInputFunctions.ApplyPlusSignMod(charWisTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charWisBonus)}");
            Console.WriteLine($"CHA : {charTrueCha}   Adj : {UserInputFunctions.ApplyPlusSignMod(charChaTempAdj)}  Mod. : {UserInputFunctions.ApplyPlusSignMod(charChaBonus)}");

            Console.WriteLine("\nAttack Bonus : " + charTotalAttackBonus);
            Console.WriteLine("Damage Bonus : " + charTotalDamageBonus);
            Console.WriteLine("Initiative Bonus : " + charInitiative);

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

            if (charInventory[slotUsed].ToUpper() == "SMALL HEALTH POTION")
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(500);

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

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "MEDIUM HEALTH POTION")
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(500);

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
            else if (charInventory[slotUsed].ToUpper() == "LARGE HEALTH POTION")
            {
                Console.Clear();

                if (charCurrHP == charTotalMaxHP)
                {
                    Console.WriteLine("Your HP is full.");

                    Thread.Sleep(500);

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

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "SMALL FATIGUE POTION")
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(500);

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

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "MEDIUM FATIGUE POTION")
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(500);

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

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "LARGE FATIGUE POTION")
            {
                Console.Clear();

                if (charCurrFatigue == charTotalMaxFatigue)
                {
                    Console.WriteLine("Your Fatigue is full.");

                    Thread.Sleep(500);

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

                Thread.Sleep(500);

                return wasItemUsed = true;
            }
            else if (charInventory[slotUsed].ToUpper() == "EMPTY")
            {
                Console.Clear();

                Console.WriteLine("This inventory slot is empty.");

                Thread.Sleep(500);

                return wasItemUsed = false;
            }
            else 
            {
                Console.Clear();

                Console.WriteLine("This is an invalid slot.");

                Thread.Sleep(500);

                return wasItemUsed = false;
            }
        }       
        
        // Need character update method that can be called after any changes?
    }
}
