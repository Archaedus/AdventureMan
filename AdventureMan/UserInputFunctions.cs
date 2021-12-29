using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal class UserInputFunctions
    {        
        public static string[] CreatePlayerCharacter() // This needs refactoring, why not just pass in the object being created to fill the fields?
        {
            bool userInputVerificationFlag = false;
            bool userInputVerificationFlag2 = false; // For shame, we need a better solution for this

            Console.WriteLine("You have selected to create a character.\n");

            string[] playerCharacterInformation = new string[12];

            do
            {
                string userInput = "";
                string userInput2 = "";
                               
                do // This entire loop is for the name alone, fucking help me.
                {
                    Console.Write("Please enter the name you would like your character to have (Greater than 0 characters and no larger than 15 characters) : ");
                    userInput = Console.ReadLine();

                    if (userInput.Length < 1 || userInput.Length > 15 || String.IsNullOrEmpty(userInput) == true)
                    {
                        Console.WriteLine("\nThis is an invalid name, please try again.");
                        userInputVerificationFlag = false;

                        Thread.Sleep(1500);
                        Console.Clear();
                    }
                    else
                    {
                        playerCharacterInformation[0] = userInput; // Assigns user input name to first slot
                        do
                        {
                            Console.WriteLine("\nThe name you have chosen is : " + playerCharacterInformation[0]);
                            Console.WriteLine("\nIs this correct? (Yes or No) ");
                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "Y" || userInput.ToUpper() == "YES")
                            {
                                Console.WriteLine("\nExcellent, moving on then.");
                                userInputVerificationFlag = true;
                                userInputVerificationFlag2 = true;

                                Thread.Sleep(1500);
                                Console.Clear();
                            }
                            else if (userInput.ToUpper() == "N" || userInput.ToUpper() == "NO")
                            {
                                Console.WriteLine("\nNo? Let's take it back to the top then.");
                                userInputVerificationFlag2 = true;

                                Thread.Sleep(1500);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("\nYou have chosen an invalid selection.");
                                userInputVerificationFlag2 = false;

                                Thread.Sleep(1500);
                                Console.Clear();
                            }
                        } while (userInputVerificationFlag2 == false);
                    }
                } while (userInputVerificationFlag == false);  // End of naming loop

                do // Start of race setting loop
                {
                    Console.WriteLine("\nPlease select a race.");
                    Console.WriteLine("\nChoices : " + CharacterRaces.raceList[0]);
                    userInput = Console.ReadLine();

                    if (CharacterRaces.raceList.Any(userInput.ToUpper().Contains))
                    {
                        playerCharacterInformation[1] = userInput.ToUpper(); // Sets race here
                        do
                        {
                            Console.WriteLine("\nThe race you have chosen is : " + playerCharacterInformation[1]);
                            Console.WriteLine("\nIs this correct? (Yes or No)");
                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "Y" || userInput.ToUpper() == "YES")
                            {
                                Console.WriteLine("\nExcellent, moving on then.");
                                userInputVerificationFlag = true;
                                userInputVerificationFlag2 = true;
                            }
                            else if (userInput.ToUpper() == "N" || userInput.ToUpper() == "NO")
                            {
                                Console.WriteLine("\nNo? Let's take it back to the top then.");
                                userInputVerificationFlag2 = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou have chosen an invalid selection.");
                                userInputVerificationFlag2 = false;
                            }
                        } while (userInputVerificationFlag2 == false);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have not chosen a valid selection. Please try again.");
                        userInputVerificationFlag = false;
                    }
                } while (userInputVerificationFlag == false); // End of race setting loop

                do // start of height, weight, age setting loop
                {
                    Console.WriteLine("\nPlease choose the height, weight, and age for your character.");

                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        Console.WriteLine("\nValid choices (race-based) : Min,Max Height = " + CharacterRaces.humMinHeight + "," + CharacterRaces.humMaxHeight + " Min,Max Weight = " + CharacterRaces.humMinWeight + "," + CharacterRaces.humMaxWeight + " Min,Max Age = " + CharacterRaces.humMinAge + "," + CharacterRaces.humMaxAge);

                        do
                        {
                            Console.Write("\nChoose Height(cm) : ");
                            userInput = Console.ReadLine();

                            if (UserInputVerifications.IsNumber(userInput) == false)
                            {
                                Console.WriteLine("\nYou have not entered a number. Going back to the top.");
                                userInputVerificationFlag = false;
                            }
                            else
                            {
                                playerCharacterInformation[2] = Convert.ToString(CharacterRaces.HeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput))); // Height is set here

                                Console.Write("\nChoose Weight(lb) : ");
                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == false)
                                {
                                    Console.WriteLine("\nYou have not entered a number. Going back to the top.");
                                    userInputVerificationFlag = false;
                                }
                                else
                                {
                                    playerCharacterInformation[3] = Convert.ToString(CharacterRaces.WeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput))); // Weight is set here

                                    Console.Write("\nChoose Age(yrs) : ");
                                    userInput = Console.ReadLine();

                                    if (UserInputVerifications.IsNumber(userInput) == false)
                                    {
                                        Console.WriteLine("\nYou have not entered a number. Going back to the top.");
                                        userInputVerificationFlag = false;
                                    }
                                    else
                                    {
                                        playerCharacterInformation[4] = Convert.ToString(CharacterRaces.AgeChecker(playerCharacterInformation[1], Convert.ToInt32(userInput))); // Age is set here

                                        do
                                        {
                                            Console.WriteLine("\nYou have chosen a Height, Weight, and Age of : " + playerCharacterInformation[2] + "cm, " + playerCharacterInformation[3] + "lbs, " + playerCharacterInformation[4] + " yrs of age");
                                            Console.Write("\nIs this correct? (Yes or No) : ");
                                            userInput = Console.ReadLine();

                                            if (userInput.ToUpper() == "Y" || userInput.ToUpper() == "YES")
                                            {
                                                Console.WriteLine("\nExcellent, moving on then.");
                                                userInputVerificationFlag = true;
                                                userInputVerificationFlag2 = true;
                                            }
                                            else if (userInput.ToUpper() == "N" || userInput.ToUpper() == "NO")
                                            {
                                                Console.WriteLine("\nNo? Let's take it back to the top then.");
                                                userInputVerificationFlag2 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nYou have chosen an invalid selection.");
                                                userInputVerificationFlag2 = false;
                                            }
                                        } while (userInputVerificationFlag2 == false);
                                    }
                                }
                            }
                        } while (userInputVerificationFlag == false);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have somehow selected an invalid race. Terminating program.");
                        Environment.Exit(0);
                    }

                } while (userInputVerificationFlag == false); // End of height, weight, age setting loop

                do // Start of attribute assignment
                {
                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        int attributePoints = 16;
                        
                        int startingAttributeTotal = CharacterRaces.humStartingAttributes[0] + CharacterRaces.humStartingAttributes[1] + CharacterRaces.humStartingAttributes[2] + CharacterRaces.humStartingAttributes[3] + CharacterRaces.humStartingAttributes[4] + CharacterRaces.humStartingAttributes[5];
                        int finalAttributeTotal = startingAttributeTotal + attributePoints;
                        int[] currAttributes = { CharacterRaces.humStartingAttributes[0], CharacterRaces.humStartingAttributes[1], CharacterRaces.humStartingAttributes[2], CharacterRaces.humStartingAttributes[3], CharacterRaces.humStartingAttributes[4], CharacterRaces.humStartingAttributes[5] };
                        int currAttributesTotal;

                        Console.WriteLine("\nNow to set your attributes. The starting attributes for your race are as follows.");
                        Console.WriteLine("\nStr : " + CharacterRaces.humStartingAttributes[0] + "\nDex : " + CharacterRaces.humStartingAttributes[1] + "\nCon : " + CharacterRaces.humStartingAttributes[2] + "\nInt : " + CharacterRaces.humStartingAttributes[3] + "\nWis : " + CharacterRaces.humStartingAttributes[4] + "\nCha : " + CharacterRaces.humStartingAttributes[5]);

                        do
                        {
                            currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                            attributePoints = finalAttributeTotal - currAttributesTotal;

                            Console.WriteLine("\nCurrent Attributes are\nStr : " + currAttributes[0] + "\nDex : " + currAttributes[1] + "\nCon : " + currAttributes[2] + "\nInt : " + currAttributes[3] + "\nWis : " + currAttributes[4] + "\nCha : " + currAttributes[5]);
                            Console.WriteLine("\nPlease choose an attribute to alter. Choices are Str, Dex, Con, Int, Wis, Cha.");
                            Console.WriteLine("\nYou have " + attributePoints + " points left to spend. They must equal 0 to progress.");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "STR" || userInput.ToUpper() == "STRENGTH")
                            {
                                Console.Write("\nHow much would you like to change it by? : ");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[0] = currAttributes[0] + Int32.Parse(userInput2);
                                    currAttributes[0] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[0]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[0] == CharacterRaces.humStartingMaxAttributes[0])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation.");
                                    }
                                    else if (currAttributes[0] == CharacterRaces.humStartingMinAttributes[0])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n You have not entered a number.\n");
                                }
                            }
                            else if (userInput.ToUpper() == "DEX" || userInput.ToUpper() == "DEXTERITY")
                            {
                                Console.Write("\nHow much would you like to change it by? : ");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[1] = currAttributes[1] + Int32.Parse(userInput2);
                                    currAttributes[1] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[1]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[1] == CharacterRaces.humStartingMaxAttributes[1])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation.");
                                    }
                                    else if (currAttributes[1] == CharacterRaces.humStartingMinAttributes[1])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nYou have not entered a number.\n");
                                }
                            }
                            else if (userInput.ToUpper() == "CON" || userInput.ToUpper() == "CONSTITUTION")
                            {
                                Console.Write("\nHow much would you like to change it by? : ");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[2] = currAttributes[2] + Int32.Parse(userInput2);
                                    currAttributes[2] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[2]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[2] == CharacterRaces.humStartingMaxAttributes[2])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation.");
                                    }
                                    else if (currAttributes[2] == CharacterRaces.humStartingMinAttributes[2])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nYou have not entered a number.");
                                }
                            }
                            else if (userInput.ToUpper() == "INT" || userInput.ToUpper() == "INTELLIGENCE")
                            {
                                Console.Write("\nHow much would you like to change it by?");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[3] = currAttributes[3] + Int32.Parse(userInput2);
                                    currAttributes[3] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[3]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[3] == CharacterRaces.humStartingMaxAttributes[3])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation.");
                                    }
                                    else if (currAttributes[3] == CharacterRaces.humStartingMinAttributes[3])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n You have not entered a number.");
                                }
                            }
                            else if (userInput.ToUpper() == "WIS" || userInput.ToUpper() == "WISDOM")
                            {
                                Console.Write("\nHow much would you like to change it by? : ");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[4] = currAttributes[4] + Int32.Parse(userInput2);
                                    currAttributes[4] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[4]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[4] == CharacterRaces.humStartingMaxAttributes[4])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation.");
                                    }
                                    else if (currAttributes[4] == CharacterRaces.humStartingMinAttributes[4])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nYou have not entered a number.");
                                }
                            }
                            else if (userInput.ToUpper() == "CHA" || userInput.ToUpper() == "CHARISMA")
                            {
                                Console.Write("\nHow much would you like to change it by? : ");
                                userInput2 = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput2) == true)
                                {
                                    currAttributes[5] = currAttributes[5] + Int32.Parse(userInput2);
                                    currAttributes[5] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userInput, currAttributes[5]);

                                    currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                                    attributePoints = finalAttributeTotal - currAttributesTotal;

                                    if (currAttributes[5] == CharacterRaces.humStartingMaxAttributes[5])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any higher at character creation for this race.");
                                    }
                                    else if (currAttributes[5] == CharacterRaces.humStartingMinAttributes[5])
                                    {
                                        Console.WriteLine("\nThis attribute cannot go any lower at character creation for this race.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nYou have not entered a number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nYou have chosen an invalid selection.");
                            }
                        } while (attributePoints > 0 || attributePoints < 0);

                        do
                        {
                            Console.WriteLine("\nFinal Attributes are\nStr : " + currAttributes[0] + "\nDex : " + currAttributes[1] + "\nCon : " + currAttributes[2] + "\nInt : " + currAttributes[3] + "\nWis : " + currAttributes[4] + "\nCha : " + currAttributes[5]);
                            Console.WriteLine("\nIs this okay? (Yes or No) : ");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                playerCharacterInformation[5] = Convert.ToString(currAttributes[0]);
                                playerCharacterInformation[6] = Convert.ToString(currAttributes[1]);
                                playerCharacterInformation[7] = Convert.ToString(currAttributes[2]);
                                playerCharacterInformation[8] = Convert.ToString(currAttributes[3]);
                                playerCharacterInformation[9] = Convert.ToString(currAttributes[4]);
                                playerCharacterInformation[10] = Convert.ToString(currAttributes[5]);

                                Console.WriteLine("\nExcellent. Assigning values now.");

                                userInputVerificationFlag = true;
                                userInputVerificationFlag2 = true;
                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                Console.WriteLine("\nI'm sorry to hear that, we'll start over.");

                                userInputVerificationFlag = false;
                                userInputVerificationFlag2 = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou have chosen an invalid selection.");

                                userInputVerificationFlag2 = false;
                            }

                        } while (userInputVerificationFlag2 == false);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid race selected. Terminating program.");
                        Environment.Exit(0);
                    }
                } while (userInputVerificationFlag == false); // End of attribute assignment

                do // Start of Class assignment
                {
                    Console.WriteLine("\nIt is now time to select your starting class. Please choose from the options below.");
                    Console.WriteLine($"Class List : {CharacterClasses.classList[0]}");

                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "FIGHTER")
                    {
                        do
                        {
                            playerCharacterInformation[11] = "Fighter";

                            Console.WriteLine("\nThe Fighter's class information is as follows.");
                            Console.WriteLine("\nHit Die : " + CharacterClasses.fighterHitDie + "\nFatigue Die : " + CharacterClasses.fighterFatigueDie + "\nAttack Bonus : +" + CharacterClasses.fighterAttackBonus + " per level " + "\nFortitude Save Bonus : " + CharacterClasses.fighterFortitudeSaveBonus + "\nReflex Save Bonus : " + CharacterClasses.fighterReflexSaveBonus + "\nWill Save Bonus : " + CharacterClasses.fighterWillSaveBonus);

                            Console.Write("\nIs this the class you want? (Yes or No) ");
                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                Console.WriteLine("\nExcellent.");

                                userInputVerificationFlag = true;
                                userInputVerificationFlag2 = true;
                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                Console.WriteLine("\nI'm sorry to hear that, select again.");

                                userInputVerificationFlag = false;
                                userInputVerificationFlag2 = true;
                            }
                            else
                            {
                                Console.WriteLine("\nYou have not selected a valid option.");

                                userInputVerificationFlag = false;
                                userInputVerificationFlag2 = false;
                            }
                        } while (userInputVerificationFlag2 == false);
                    }
                    else
                    {
                        Console.WriteLine("\nYou have chosen an invalid selection.");
                        userInputVerificationFlag = false;
                    }

                } while (userInputVerificationFlag == false); // End of Class Assignment

                Console.WriteLine("Congratulations, we are nearing the end of character creation.");
                Console.WriteLine("\nHere is all the information about your created character.");

                do // Final selection
                {
                    Console.WriteLine("\nName : " + playerCharacterInformation[0] + "\nRace : " + playerCharacterInformation[1] + "\n\nHeight(cm) : " + playerCharacterInformation[2] + "\nWeight(lb) : " + playerCharacterInformation[3] + "\nAge(yrs) : " + playerCharacterInformation[4] + "\n\nClass : " + playerCharacterInformation[11] + "\n\nSTR : " + playerCharacterInformation[5] + "\nDEX : " + playerCharacterInformation[6] + "\nCON : " + playerCharacterInformation[7] + "\nINT : " + playerCharacterInformation[8] + "\nWIS : " + playerCharacterInformation[9] + "\nCHA : " + playerCharacterInformation[10]);

                    Console.Write("\nIs this the character you wanted to make? (Yes or No)");
                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y") 
                    {
                        Console.WriteLine("\nExcellent. You have successfully created a character.");

                        userInputVerificationFlag = true;
                        userInputVerificationFlag2 = true;
                    }
                    else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                    {
                        Console.WriteLine("\nI'm sorry to hear that, let's start the whole thing over then shall we?");

                        userInputVerificationFlag = false;
                        userInputVerificationFlag2 = true;
                    }
                    else
                    {
                        Console.WriteLine("\nYou have not selected a valid option.");

                        userInputVerificationFlag = false;
                        userInputVerificationFlag2 = false;
                    }
                } while (userInputVerificationFlag2 == false); // End of final selection
            } while (userInputVerificationFlag == false);

            return playerCharacterInformation;
        }

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
