using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdventureMan
{
    internal static class MenuCommands
    {
        public static void InventoryCommand(Character character)
        {
            string userInput;
            bool inventoryLoopFlag = true;

            Console.Clear();

            Console.WriteLine("Opening Inventory...");
            Thread.Sleep(1000);

            while (inventoryLoopFlag == true)
            {
                int inventoryPosition = 1;

                Console.Clear();
                Console.WriteLine("Inventory Slots :");

                foreach (string slot in character.charInventory)
                {
                    Console.WriteLine("Slot " + inventoryPosition + " : " + slot);

                    inventoryPosition++;
                }

                Console.WriteLine("\nSelect a slot to have more options. Enter Quit to leave the inventory.");

                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "SLOT 1" || userInput.ToUpper() == "1" || userInput.ToUpper() == "SLOT1")
                {
                    if (character.charInventory[0].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[0]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(0);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[0] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 2" || userInput.ToUpper() == "2" || userInput.ToUpper() == "SLOT2")
                {
                    if (character.charInventory[1].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[1]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(1);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[1] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 3" || userInput.ToUpper() == "3" || userInput.ToUpper() == "SLOT3")
                {
                    if (character.charInventory[2].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[2]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(2);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[2] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 4" || userInput.ToUpper() == "4" || userInput.ToUpper() == "SLOT4")
                {
                    if (character.charInventory[3].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[3]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(3);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[3] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 5" || userInput.ToUpper() == "5" || userInput.ToUpper() == "SLOT5")
                {
                    if (character.charInventory[4].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[4]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(4);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[4] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 6" || userInput.ToUpper() == "6" || userInput.ToUpper() == "SLOT6")
                {
                    if (character.charInventory[5].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[5]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(5);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[5] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 7" || userInput.ToUpper() == "7" || userInput.ToUpper() == "SLOT7")
                {
                    if (character.charInventory[6].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[6]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(6);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[6] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 8" || userInput.ToUpper() == "8" || userInput.ToUpper() == "SLOT8")
                {
                    if (character.charInventory[7].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[7]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(7);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[7] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 9" || userInput.ToUpper() == "9" || userInput.ToUpper() == "SLOT9")
                {
                    if (character.charInventory[8].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[8]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(8);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[8] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 10" || userInput.ToUpper() == "10" || userInput.ToUpper() == "SLOT10")
                {
                    if (character.charInventory[9].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[9]);

                            Console.WriteLine("\nWould you like to use or equip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "USE")
                            {
                                wasItemUsed = character.ItemUseBehavior(9);

                                if (wasItemUsed == true)
                                {
                                    character.charInventory[9] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "EQUIP")
                            {
                                Console.Clear();

                                Console.WriteLine("In progress.");

                                Thread.Sleep(500);

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(500);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(500);
                    }
                }
                else if (userInput.ToUpper() == "QUIT" || userInput.ToUpper() == "Q")
                {
                    Console.Clear();

                    Console.WriteLine("Leaving Inventory...");

                    Thread.Sleep(1000);

                    inventoryLoopFlag = false;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("You have chosen an invalid selection smoothbrain.");

                    Thread.Sleep(1000);
                }
            }
        }

        public static void DebugShop(Character character)
        {
            string userInput;
            bool shopLoop = true;

            while (shopLoop == true)
            {
                Console.Clear();

                Console.WriteLine("Hello, and welcome to my debug shop. Everything is free because I am terrible at business. What do you want?");

                Console.WriteLine("\nSHOP INVENTORY");
                Console.WriteLine($"\n{ItemAttributeList.healthPotionSName} - Price : {ItemAttributeList.healthPotionSValue}");
                Console.WriteLine($"{ItemAttributeList.healthPotionMName} - Price : {ItemAttributeList.healthPotionMValue}");
                Console.WriteLine($"{ItemAttributeList.healthPotionLName} - Price : {ItemAttributeList.healthPotionLValue}");
                Console.WriteLine($"{ItemAttributeList.fatiguePotionSName} - Price : {ItemAttributeList.fatiguePotionSValue}");
                Console.WriteLine($"{ItemAttributeList.fatiguePotionMName} - Price : {ItemAttributeList.fatiguePotionMValue}");
                Console.WriteLine($"{ItemAttributeList.fatiguePotionLName} - Price : {ItemAttributeList.fatiguePotionLValue}");

                userInput = Console.ReadLine();

                if (userInput.ToUpper() == ItemAttributeList.healthPotionSName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.healthPotionSName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.healthPotionSName;

                                Console.WriteLine($"\n{ItemAttributeList.healthPotionSName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(1000);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(1000);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (userInput.ToUpper() == ItemAttributeList.healthPotionMName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.healthPotionMName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.healthPotionMName;

                                Console.WriteLine($"\n{ItemAttributeList.healthPotionMName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(1000);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(1000);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (userInput.ToUpper() == ItemAttributeList.healthPotionLName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.healthPotionLName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.healthPotionLName;

                                Console.WriteLine($"\n{ItemAttributeList.healthPotionLName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(1000);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(1000);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (userInput.ToUpper() == ItemAttributeList.fatiguePotionSName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.fatiguePotionSName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.fatiguePotionSName;

                                Console.WriteLine($"\n{ItemAttributeList.fatiguePotionSName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(500);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(500);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(500);
                        }
                    }
                }
                else if (userInput.ToUpper() == ItemAttributeList.fatiguePotionMName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.fatiguePotionMName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.fatiguePotionSName;

                                Console.WriteLine($"\n{ItemAttributeList.fatiguePotionSName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(1000);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(1000);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (userInput.ToUpper() == ItemAttributeList.fatiguePotionLName.ToUpper())
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.fatiguePotionLName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition < 100)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.fatiguePotionLName;

                                Console.WriteLine($"\n{ItemAttributeList.fatiguePotionLName} was placed in slot {assignedInventoryPosition + 1}");

                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("I'm sorry, but your inventory is full. Come back after you have some room.");

                                Thread.Sleep(1000);
                            }

                            shopLoop2 = false;
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            Console.Clear();

                            Console.WriteLine("No? Well, let's see if we can find something you DO like.");

                            Thread.Sleep(1000);

                            shopLoop2 = false;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("A yes or a no would be preferable to whatever it is just came out of your mouth.");

                            Thread.Sleep(1000);
                        }
                    }
                }
                else if (userInput.ToUpper() == "QUIT")
                {
                    Console.Clear();

                    Console.WriteLine("I'll see you around stranger! Come back anytime!");

                    Thread.Sleep(1000);

                    shopLoop = false;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Yeah... I ain't got whatever you're asking for stranger. Care to try again?");

                    Thread.Sleep(1000);
                }
            }
        }

        public static string[] CreatePlayerCharacter() 
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

        public static string[] CreatePlayerCharacter2() 
        {
            bool userInputVerificationFlag;
            bool yesOrNoLoopFlag;
            bool heightWeightAgeLoopFlag;
            string userInput;
            string[] playerCharacterInformation = new string[12];

            Console.Clear();

            Console.WriteLine("You have selected to create a new character.");

            Thread.Sleep(1000);

            do // Name setting loop
            {
                userInputVerificationFlag = true;
                yesOrNoLoopFlag = true;

                Console.Clear();

                Console.Write("What is your character's name? ");

                userInput = Console.ReadLine();

                if (userInput.Length <= 15 || String.IsNullOrEmpty(userInput) == false)
                {
                    playerCharacterInformation[0] = userInput;
                  
                    do
                    {
                        Console.Clear();

                        Console.WriteLine($"The name you have selected is : {playerCharacterInformation[0]}");

                        Console.Write("\nIs this the name you want? ");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            userInputVerificationFlag = false;
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"Your name is now set to : {playerCharacterInformation[0]}");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;
                            
                            Console.Clear();

                            Console.WriteLine("No? Then I'll give you another chance.");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    } while (yesOrNoLoopFlag == true);                                       
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine($"{userInput} is an invalid name. A name must have at least 1 character and fewer than 16.");

                    Thread.Sleep(1000);
                }
            } while (userInputVerificationFlag == true); // End of name setting loop

            do // Race setting loop
            {
                userInputVerificationFlag = true;
                yesOrNoLoopFlag = true;

                Console.Clear();

                Console.WriteLine("Race Options\n");
                UserInputFunctions.ListAllElements(CharacterRaces.raceList);

                Console.Write("\nWhat race would you like to be? ");

                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "HUMAN")
                {
                    playerCharacterInformation[1] = "Human";

                    do 
                    {
                        Console.Clear();

                        CharacterRaces.DisplayRaceInformation(playerCharacterInformation[1]);

                        Console.Write("\nIs this the race you want to be? ");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            userInputVerificationFlag = false;
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine($"Your race has been set to {playerCharacterInformation[1]}");

                            Thread.Sleep(1000);
                        }
                        else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                        {
                            yesOrNoLoopFlag = false;

                            Console.Clear();

                            Console.WriteLine("Having second thoughts? Let's try again.");

                            Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userInput} is not a valid selection.");

                            Thread.Sleep(1000);
                        }
                    } while (yesOrNoLoopFlag == true);                   
                }
                else if (userInput.ToUpper() == "TBD")
                {
                    Console.Clear();

                    Console.WriteLine($"{userInput} is not a valid selection. It's WIP right now.");

                    Thread.Sleep(1000);
                }
                else 
                {
                    Console.Clear();

                    Console.WriteLine($"{userInput} is not a valid selection.");

                    Thread.Sleep(1000);
                }
            } while (userInputVerificationFlag == true); // End of race setting loop

            do // Overarching loop for Height, Weight and Age
            {
                heightWeightAgeLoopFlag = true;

                do // Height setting loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        Console.Clear();

                        Console.WriteLine($"Min, Max Height(cm) : {CharacterRaces.humMinHeight}, {CharacterRaces.humMaxHeight}");

                        Console.Write("\nPlease set your height(cm) : ");

                        userInput = Console.ReadLine();

                        if (UserInputVerifications.IsNumber(userInput) == true)
                        {
                            playerCharacterInformation[2] = Convert.ToString(CharacterRaces.HeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput)));

                            do
                            {
                                Console.Clear();

                                Console.Write($"\nIs {playerCharacterInformation[2]} the height you want? ");

                                userInput = Console.ReadLine();

                                if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                                {
                                    userInputVerificationFlag = false;
                                    yesOrNoLoopFlag = false;

                                    Console.WriteLine($"Height has been set to {playerCharacterInformation[2]}.");

                                    Thread.Sleep(1000);
                                }
                                else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                                {
                                    yesOrNoLoopFlag = false;

                                    Console.WriteLine("No? Let's try again then.");

                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.Clear();
                                }
                            } while (yesOrNoLoopFlag == true);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("You have not entered a valid number.");

                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Somehow an invalid race has been selected. Ending program...");

                        Environment.Exit(0);
                    }
                } while (userInputVerificationFlag == true); // End of Height setting loop

                do // Weight setting loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        Console.Clear();

                        Console.WriteLine($"Min, Max Weight(lb) : {CharacterRaces.humMinWeight}, {CharacterRaces.humMaxWeight}");

                        Console.Write("\nPlease set your weight(lb) : ");

                        userInput = Console.ReadLine();

                        if (UserInputVerifications.IsNumber(userInput) == true)
                        {
                            playerCharacterInformation[3] = Convert.ToString(CharacterRaces.HeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput)));

                            do
                            {
                                Console.Clear();

                                Console.Write($"\nIs {playerCharacterInformation[3]} the weight you want? ");

                                userInput = Console.ReadLine();

                                if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                                {
                                    userInputVerificationFlag = false;
                                    yesOrNoLoopFlag = false;

                                    Console.WriteLine($"Weight has been set to {playerCharacterInformation[3]}.");

                                    Thread.Sleep(1000);
                                }
                                else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                                {
                                    yesOrNoLoopFlag = false;

                                    Console.WriteLine("No? Let's try again then.");

                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.Clear();
                                }
                            } while (yesOrNoLoopFlag == true);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("You have not entered a valid number.");

                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Somehow an invalid race has been selected. Ending program...");

                        Environment.Exit(0);
                    }
                } while (userInputVerificationFlag == true); // End of Weight setting loop

                do // Age setting loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        Console.Clear();

                        Console.WriteLine($"Min, Max Age(yrs) : {CharacterRaces.humMinAge}, {CharacterRaces.humMaxAge}");

                        Console.Write("\nPlease set your age(yrs) : ");

                        userInput = Console.ReadLine();

                        if (UserInputVerifications.IsNumber(userInput) == true)
                        {
                            playerCharacterInformation[4] = Convert.ToString(CharacterRaces.HeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput)));

                            do
                            {
                                Console.Clear();

                                Console.Write($"\nIs {playerCharacterInformation[4]} the age you want? ");

                                userInput = Console.ReadLine();

                                if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                                {
                                    userInputVerificationFlag = false;
                                    yesOrNoLoopFlag = false;

                                    Console.Clear();
                                    
                                    Console.WriteLine($"Age has been set to {playerCharacterInformation[4]}.");

                                    Thread.Sleep(1000);
                                }
                                else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                                {
                                    yesOrNoLoopFlag = false;

                                    Console.Clear();

                                    Console.WriteLine("No? Let's try again then.");

                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.Clear();
                                }
                            } while (yesOrNoLoopFlag == true);
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("You have not entered a valid number.");

                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Somehow an invalid race has been selected. Ending program...");

                        Environment.Exit(0);
                    }
                } while (userInputVerificationFlag == true); // End of Age setting loop

                do 
                {
                    yesOrNoLoopFlag = true;

                    Console.Clear();

                    Console.WriteLine($"Height(cm) : {playerCharacterInformation[2]}" +
                        $"\nWeight(lb) : {playerCharacterInformation[3]}" +
                        $"\nAge(yrs) : {playerCharacterInformation[4]}");

                    Console.Write("\nAre these values ok? ");

                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                    {
                        heightWeightAgeLoopFlag = false;
                        yesOrNoLoopFlag = false;

                        Console.Clear();

                        Console.WriteLine("All values finalized.");

                        Thread.Sleep(1000);
                    }
                    else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                    {
                        yesOrNoLoopFlag = false;

                        Console.Clear();

                        Console.WriteLine("No? Well, let's start over then.");

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("You have not enter a valid selection.");

                        Thread.Sleep(1000);

                    }
                } while (yesOrNoLoopFlag == true);  
                
            } while ( heightWeightAgeLoopFlag == true); // End of overarching height, weight, age loop

            do // Start of attribute setting loop
            {
                userInputVerificationFlag = true;

                if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                {
                    int attributePoints = CharacterRaces.humStartingAttributePoints;
                    string userAttributeInput;

                    int startingAttributeTotal = CharacterRaces.humStartingAttributes[0] + CharacterRaces.humStartingAttributes[1] + CharacterRaces.humStartingAttributes[2] + CharacterRaces.humStartingAttributes[3] + CharacterRaces.humStartingAttributes[4] + CharacterRaces.humStartingAttributes[5];
                    int finalAttributeTotal = startingAttributeTotal + attributePoints;
                    int[] currAttributes = { CharacterRaces.humStartingAttributes[0], CharacterRaces.humStartingAttributes[1], CharacterRaces.humStartingAttributes[2], CharacterRaces.humStartingAttributes[3], CharacterRaces.humStartingAttributes[4], CharacterRaces.humStartingAttributes[5] };

                    Console.Clear();

                    Console.WriteLine("Now to set your starting attributes.");

                    Thread.Sleep(1000);

                    do
                    {
                        int currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];
                        attributePoints = finalAttributeTotal - currAttributesTotal;

                        Console.Clear();

                        Console.WriteLine($"Current Attributes" +
                            $"\n\nSTR : {currAttributes[0]}" +
                            $"\nDEX : {currAttributes[1]}" +
                            $"\nCON : {currAttributes[2]}" +
                            $"\nINT : {currAttributes[3]}" +
                            $"\nWIS : {currAttributes[4]}" +
                            $"\nCHA : {currAttributes[5]}");

                        Console.WriteLine($"\nYou have {attributePoints} remaining...");

                        Console.Write("\nSelect an attribute you would like to change : ");

                        userAttributeInput = Console.ReadLine();

                        if (userAttributeInput.ToUpper() == "STR" || userAttributeInput.ToUpper() == "STRENGTH")
                        {
                            Console.Clear();

                            Console.WriteLine($"Current STR : {currAttributes[0]}   Racial Min,Max : {CharacterRaces.humStartingMaxAttributes[0]},{CharacterRaces.humStartingMinAttributes[0]}");

                            Console.WriteLine($"\nYou have {attributePoints} to spend...");
                            
                            Console.Write($"\nHow much would you like to change {userAttributeInput} by : ");

                            userInput = Console.ReadLine();

                            if (UserInputVerifications.IsNumber(userInput) == true)
                            {
                                if (Convert.ToInt32(userInput) <= attributePoints)
                                {
                                    currAttributes[0] = currAttributes[0] + Convert.ToInt32(userInput);

                                    currAttributes[0] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[0]);
                                }
                                else 
                                {
                                    Console.Clear();

                                    Console.WriteLine("There are not enough remaining attribute points to spend.");

                                    Thread.Sleep(1000);
                                }
                            }
                            else 
                            {
                                Console.Clear();

                                Console.WriteLine($"{userInput} is not a valid number.");

                                Thread.Sleep(1000);
                            }
                        }
                        else if (userAttributeInput.ToUpper() == "DEX" || userAttributeInput.ToUpper() == "DEXTERITY")
                        {

                        }
                        else if (userAttributeInput.ToUpper() == "CON" || userAttributeInput.ToUpper() == "CONSTITUTION")
                        {

                        }
                        else if (userAttributeInput.ToUpper() == "INT" || userAttributeInput.ToUpper() == "INTELLIGENCE")
                        {

                        }
                        else if (userAttributeInput.ToUpper() == "WIS" || userAttributeInput.ToUpper() == "WISDOM")
                        {

                        }
                        else if (userAttributeInput.ToUpper() == "CHA" || userAttributeInput.ToUpper() == "CHARISMA")
                        {

                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine($"{userAttributeInput} is not a valid choice.");

                            Thread.Sleep(1000);
                        }
                    } while (attributePoints != 0);
                }
                else 
                {
                    Console.Clear();

                    Console.WriteLine("An invalid race has been selected. Terminating program...");

                    Thread.Sleep(1000);

                    Environment.Exit(0);
                }
            } while (userInputVerificationFlag == true); // End of attribute setting loop
        }
    }
}   


