using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal static class CharacterRaces
    {
        public static string[] raceList = { "HUMAN", "TBD" };

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

        public static int humStartingAttributePoints = 20;
        #endregion

        public static int HeightChecker (string charRace, int charHeight)
        {
            if (charRace.ToUpper() == "HUMAN")
            {
                if (charHeight > humMaxHeight)
                {
                    Console.Clear();

                    Console.WriteLine($"{charHeight} is too large. Setting height to default maximum for race. ({humMaxHeight})");

                    Thread.Sleep(1000);

                    charHeight = humMaxHeight;

                    return charHeight;
                }
                else if (charHeight < humMinHeight)
                {
                    Console.Clear();

                    Console.WriteLine($"{charHeight} is too small. Setting height to default minimum for race. ({humMinHeight})");

                    Thread.Sleep(1000);

                    charHeight = humMinHeight;

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
                    Console.Clear();

                    Console.WriteLine($"{charWeight} is too large. Setting weight to default maximum for race. ({humMaxWeight})");

                    Thread.Sleep(1000);

                    charWeight = humMaxWeight;

                    return charWeight;
                }
                else if (charWeight < humMinWeight)
                {
                    Console.Clear();

                    Console.WriteLine($"{charWeight} is too small. Setting weight to default maximum for race. ({humMinWeight})");

                    Thread.Sleep(1000);

                    charWeight = humMinWeight;

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
                    Console.Clear();

                    Console.WriteLine($"{charAge} is too old. Setting age to default maximum for race. ({humMaxAge})");

                    Thread.Sleep(1000);

                    charAge = humMaxAge;

                    return charAge;
                }
                else if (charAge < humMinAge)
                {
                    Console.Clear();

                    Console.WriteLine($"{charAge} is too young. Setting age to default maximum for race. ({humMinAge})");

                    Thread.Sleep(1000);

                    charAge = humMinAge;

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

        public static int AttributeChecker(string charRace, string charAttribute, int attributeToBeChecked) 
        {
            int assignedAttribute = 0;

            #region Human Attribute Checker

            if (charRace.ToUpper() == "HUMAN")
            {
                if (charAttribute.ToUpper() == "STR" || charAttribute.ToUpper() == "STRENGTH")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[0])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[0]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[0]}.");

                        Thread.Sleep(1000);
                        
                        assignedAttribute = humStartingMaxAttributes[0];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[0])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[0]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[0]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[0];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();
                        
                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "DEX" || charAttribute.ToUpper() == "DEXTERITY")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[1])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[1]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[1]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMaxAttributes[1];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[1])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[1]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[1]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[1];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "CON" || charAttribute.ToUpper() == "CONSTITUTION")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[2])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[2]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[2]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMaxAttributes[2];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[2])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[2]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[2]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[2];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "INT" || charAttribute.ToUpper() == "INTELLIGENCE")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[3])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[3]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[3]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMaxAttributes[3];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[3])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[3]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[3]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[3];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "WIS" || charAttribute.ToUpper() == "WISDOM")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[4])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[4]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[4]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMaxAttributes[4];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[4])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[4]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[4]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[4];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

                        return assignedAttribute;
                    }
                }
                else if (charAttribute.ToUpper() == "CHA" || charAttribute.ToUpper() == "CHARISMA")
                {
                    if (attributeToBeChecked > humStartingMaxAttributes[5])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot exceed {humStartingMaxAttributes[5]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMaxAttributes[5]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMaxAttributes[5];

                        return assignedAttribute;
                    }
                    else if (attributeToBeChecked < humStartingMinAttributes[5])
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} cannot go lower than {humStartingMinAttributes[5]} for {charRace}s. {charAttribute.ToUpper()} set to {humStartingMinAttributes[5]}.");

                        Thread.Sleep(1000);

                        assignedAttribute = humStartingMinAttributes[5];

                        return assignedAttribute;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{charAttribute.ToUpper()} set to {attributeToBeChecked}.");

                        Thread.Sleep(1000);

                        assignedAttribute = attributeToBeChecked;

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

                Thread.Sleep(1000);
                
                return assignedAttribute;
            }
            
        }

        public static void DisplayRaceInformation(string aRace) 
        {
            if (aRace.ToUpper() == "HUMAN")
            {
                Console.WriteLine($"HUMAN" +
                    $"\n\nMax Height(cm) : {humMaxHeight}\nMin Height(cm) : {humMinHeight}" +
                    $"\n\nMax Weight(lb) : {humMaxWeight}\nMin Weight(lb) : {humMinWeight}" +
                    $"\n\nMax Age(yr) : {humMaxAge}\nMin Age(yr) : {humMinAge}" +
                    $"\n\nStarting Attributes   Min.Starting Attr.  Max Starting Attr." +
                    $"\n\nSTR     {humStartingAttributes[0]}                      {humStartingMinAttributes[0]}                   {humStartingMaxAttributes[0]}" +
                    $"\nDEX     {humStartingAttributes[1]}                      {humStartingMinAttributes[1]}                   {humStartingMaxAttributes[1]}" +
                    $"\nCON     {humStartingAttributes[2]}                      {humStartingMinAttributes[2]}                   {humStartingMaxAttributes[2]}" +
                    $"\nINT     {humStartingAttributes[3]}                      {humStartingMinAttributes[3]}                   {humStartingMaxAttributes[3]}" +
                    $"\nWIS     {humStartingAttributes[4]}                      {humStartingMinAttributes[4]}                   {humStartingMaxAttributes[4]}" +
                    $"\nCHA     {humStartingAttributes[5]}                      {humStartingMinAttributes[5]}                   {humStartingMaxAttributes[5]}" +
                    $"\n\nAttribute Points to spend : {humStartingAttributePoints}");
            }
            else 
            {
                Console.Clear();

                Console.WriteLine("This is not a valid race for this method.");

                Thread.Sleep(1000);
            }
        }
    }
}
