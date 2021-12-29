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
    }
}
