using System;
using System.Threading;

namespace AdventureMan
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to the character creator. Please hit the enter key to begin the character creation process.");
            Console.ReadLine();

            string[] playerCharacterArray = MenuCommands.CreatePlayerCharacter();

            Character playerCharacter = new Character(playerCharacterArray[0], playerCharacterArray[1], Convert.ToInt32(playerCharacterArray[2]), Convert.ToInt32(playerCharacterArray[3]), Convert.ToInt32(playerCharacterArray[4]), Convert.ToInt32(playerCharacterArray[5]), Convert.ToInt32(playerCharacterArray[6]), Convert.ToInt32(playerCharacterArray[7]), Convert.ToInt32(playerCharacterArray[8]), Convert.ToInt32(playerCharacterArray[9]), Convert.ToInt32(playerCharacterArray[10]), playerCharacterArray[11]);

            Console.WriteLine("Creating player...");
            Thread.Sleep(2000);
            Console.WriteLine("Player created!");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Your commands are : PlayerInfo, LevelUp, Shop, View Inventory, Hurt me, or Quit. \n\nPlease choose an option by typing a command.");

                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "PLAYERINFO" || userInput.ToUpper() == "PLAYER INFO")
                {
                    Console.Clear();

                    Console.WriteLine("Displaying Player Information...\n");
                    Thread.Sleep(1000);
                    playerCharacter.DisplayPlayerCharacterInformation();

                    Console.WriteLine("\nPress any key to be brought back to the selection menu...");
                    Console.ReadLine();
                }
                else if (userInput.ToUpper() == "LEVELUP" || userInput.ToUpper() == "LEVEL UP")
                {
                    Console.Clear();
                    
                    Console.WriteLine("Leveling up " + playerCharacter.charName + "...");
                    Thread.Sleep(1000);

                    playerCharacter.CharacterLevelUp(playerCharacter.charClass);

                    Console.WriteLine(playerCharacter.charName + " is now successfully level " + playerCharacter.charLevel + ".");

                    Console.WriteLine("\nPress any key to be brought back to the selection menu...");
                    Console.ReadLine();
                }
                else if (userInput.ToUpper() == "SHOP")
                {
                    MenuCommands.DebugShop(playerCharacter);
                }
                else if (userInput.ToUpper() == "INVENTORY" || userInput.ToUpper() == "VIEW INVENTORY" || userInput.ToUpper() == "VIEWINVENTORY" || userInput.ToUpper() == "I")
                {
                    MenuCommands.InventoryCommand(playerCharacter);
                }
                else if (userInput.ToUpper() == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("\nThank you for participating in this test. Press any key to exit the program...");

                    Thread.Sleep(1000);

                    break;
                }
                else if (userInput.ToUpper() == "HURTME" || userInput.ToUpper() == "HURT ME")
                {
                    Console.Clear();

                    Console.WriteLine("Hurting you plenty...");

                    playerCharacter.charCurrHP = 1;
                    playerCharacter.charCurrFatigue = 1;

                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("\nYou have chosen an invalid selection. Can you read? Give me a fucking break. Press any key to try again retard.");
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
