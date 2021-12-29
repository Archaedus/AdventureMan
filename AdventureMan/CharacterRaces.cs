using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMan
{
    internal static class CharacterRaces
    {
        public static string[] raceList = { "HUMAN" };

        // Human Race

        #region Human Race
        public static int humMaxHeight = 198; // cm
        public static int humMinHeight = 150;

        public static int humMaxWeight = 200; // Pounds
        public static int humMinWeight = 100;

        public static int humMaxAge = 45;
        public static int humMinAge = 18;

        public static int[] humStartingAttributes = { 10, 10, 10, 10, 10, 10 };
        public static int[] humStartingMaxAttributes = { 20, 20, 20, 20, 20, 20 };
        public static int[] humStartingMinAttributes = { 6, 6, 6, 6, 6, 6 }; 
        #endregion

        public static int HeightChecker (string charRace, int charHeight)
        {
            if (charRace.ToUpper() == "HUMAN")
            {
                if (charHeight > humMaxHeight)
                {
                    charHeight = 198;

                    return charHeight;
                }
                else if (charHeight < humMinHeight)
                {
                    charHeight = 150;

                    return charHeight;
                }
                else
                {
                    return charHeight;
                }
            }
            else 
            {
                return charHeight;
            }
        }

        public static int WeightChecker(string charRace, int charWeight)
        {
            if (charRace.ToUpper() == "HUMAN")
            {
                if (charWeight > humMaxWeight)
                {
                    charWeight = 200;

                    return charWeight;
                }
                else if (charWeight < humMinWeight)
                {
                    charWeight = 100;

                    return charWeight;
                }
                else
                {
                    return charWeight;
                }
            }
            else
            {
                return charWeight;
            }
        }

        public static int AgeChecker(string charRace, int charAge)
        {
            if (charRace.ToUpper() == "HUMAN")
            {
                if (charAge > humMaxAge)
                {
                    charAge = 45;

                    return charAge;
                }
                else if (charAge < humMinAge)
                {
                    charAge = 18;

                    return charAge;
                }
                else
                {
                    return charAge;
                }
            }
            else
            {
                return charAge;
            }
        }

        public static int AttributeChecker(string charRace, string charAttribute, int userInputAttribute) 
        {
            int assignedAttribute = 0;

            #region Human Attribute Checker

            if (charRace.ToUpper() == "HUMAN")
            {
                if (charAttribute.ToUpper() == "STR" || charAttribute.ToUpper() == "STRENGTH")
                {
                    if (userInputAttribute > humStartingMaxAttributes[0])
                    {
                        assignedAttribute = humStartingMaxAttributes[0];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[0])
                    {
                        assignedAttribute = humStartingMinAttributes[0];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "DEX" || charAttribute.ToUpper() == "DEXTERITY")
                {
                    if (userInputAttribute > humStartingMaxAttributes[1])
                    {
                        assignedAttribute = humStartingMaxAttributes[1];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[1])
                    {
                        assignedAttribute = humStartingMinAttributes[1];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "CON" || charAttribute.ToUpper() == "CONSTITUTION")
                {
                    if (userInputAttribute > humStartingMaxAttributes[2])
                    {
                        assignedAttribute = humStartingMaxAttributes[2];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[2])
                    {
                        assignedAttribute = humStartingMinAttributes[2];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "INT" || charAttribute.ToUpper() == "INTELLIGENCE")
                {
                    if (userInputAttribute > humStartingMaxAttributes[3])
                    {
                        assignedAttribute = humStartingMaxAttributes[3];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[3])
                    {
                        assignedAttribute = humStartingMinAttributes[3];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "WIS" || charAttribute.ToUpper() == "WISDOM")
                {
                    if (userInputAttribute > humStartingMaxAttributes[4])
                    {
                        assignedAttribute = humStartingMaxAttributes[4];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[4])
                    {
                        assignedAttribute = humStartingMinAttributes[4];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "CHA" || charAttribute.ToUpper() == "CHARISMA")
                {
                    if (userInputAttribute > humStartingMaxAttributes[5])
                    {
                        assignedAttribute = humStartingMaxAttributes[5];

                        return assignedAttribute;
                    }
                    else if (userInputAttribute < humStartingMinAttributes[5])
                    {
                        assignedAttribute = humStartingMinAttributes[5];

                        return assignedAttribute;
                    }
                    else
                    {
                        assignedAttribute = userInputAttribute;

                        return assignedAttribute;
                    }
                }
                else
                {
                    return assignedAttribute;
                }
            }

            #endregion

            else
            {
                Console.WriteLine("Something has gone wrong, an invalid race has made it through.");
                
                return assignedAttribute;
            }
            
        }
    }
}
