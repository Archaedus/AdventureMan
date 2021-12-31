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
                Console.Clear();

                character.DisplayEquipmentSlots();

                character.DisplayInventorySlots();

                Console.WriteLine("\nSelect a slot to have more options. Enter Quit to leave the inventory.");

                userInput = Console.ReadLine();

                #region Inventory Slots

                if (userInput.ToUpper() == "SLOT 1" || userInput.ToUpper() == "1" || userInput.ToUpper() == "SLOT1")
                {
                    if (character.charInventory[0].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[0]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(0);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[0] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(0);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[0] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 2" || userInput.ToUpper() == "2" || userInput.ToUpper() == "SLOT2")
                {
                    if (character.charInventory[1].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[1]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(1);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[1] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(1);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[1] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 3" || userInput.ToUpper() == "3" || userInput.ToUpper() == "SLOT3")
                {
                    if (character.charInventory[2].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[2]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(2);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[2] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(2);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[2] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 4" || userInput.ToUpper() == "4" || userInput.ToUpper() == "SLOT4")
                {
                    if (character.charInventory[3].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[3]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(3);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[3] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(3);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[3] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 5" || userInput.ToUpper() == "5" || userInput.ToUpper() == "SLOT5")
                {
                    if (character.charInventory[4].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[4]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(4);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[4] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(4);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[4] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 6" || userInput.ToUpper() == "6" || userInput.ToUpper() == "SLOT6")
                {
                    if (character.charInventory[5].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[5]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(5);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[5] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(5);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[5] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 7" || userInput.ToUpper() == "7" || userInput.ToUpper() == "SLOT7")
                {
                    if (character.charInventory[6].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[6]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(6);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[6] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(6);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[6] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 8" || userInput.ToUpper() == "8" || userInput.ToUpper() == "SLOT8")
                {
                    if (character.charInventory[7].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[7]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(7);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[7] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(7);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[7] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 9" || userInput.ToUpper() == "9" || userInput.ToUpper() == "SLOT9")
                {
                    if (character.charInventory[8].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[8]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(8);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[8] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(8);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[8] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "SLOT 10" || userInput.ToUpper() == "10" || userInput.ToUpper() == "SLOT10")
                {
                    if (character.charInventory[9].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUsed = false;
                        bool wasItemEquipped = false;
                        bool wasItemDropped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charInventory[9]);

                            Console.WriteLine("\nWould you like to use, equip, or drop this item?");

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
                                wasItemEquipped = character.EquipUseBehavior(9);

                                if (wasItemEquipped == true)
                                {
                                    character.charInventory[9] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else if (userInput.ToUpper() == "DROP")
                            {
                                wasItemDropped = character.DropItemBehavior(9);

                                if (wasItemDropped == true)
                                {
                                    character.charInventory[9] = "Empty";
                                }

                                inventoryLoopFlag2 = false;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("You have chosen an invalid selection.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("This inventory slot is empty.");

                        Thread.Sleep(1000);
                    }
                }

                #endregion


                #region Equipment Slots

                else if (userInput.ToUpper() == "RH" || userInput.ToUpper() == "RIGHT HAND" || userInput.ToUpper() == "R" || userInput.ToUpper() == "RIGHTHAND" || userInput.ToUpper() == "RIGHT")
                {
                    if (character.charEquipmentLoadOut[0].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true) 
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[0]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(0);

                                if (wasItemUnEquipped == true) 
                                {
                                    if (character.charIsTwoHanding == true) 
                                    {
                                        character.charEquipmentLoadOut[0] = "Empty";
                                        character.charEquipmentLoadOut[1] = "Empty";

                                        character.charIsTwoHanding = false;
                                    }
                                    
                                    character.charEquipmentLoadOut[0] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else 
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }     
                }
                else if (userInput.ToUpper() == "LH" || userInput.ToUpper() == "LEFT HAND" || userInput.ToUpper() == "L" || userInput.ToUpper() == "LEFTHAND" || userInput.ToUpper() == "LEFT")
                {
                    if (character.charEquipmentLoadOut[1].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[1]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(1);

                                if (wasItemUnEquipped == true)
                                {
                                    if (character.charIsTwoHanding == true)
                                    {
                                        character.charEquipmentLoadOut[0] = "Empty";
                                        character.charEquipmentLoadOut[1] = "Empty";

                                        character.charIsTwoHanding = false;
                                    }

                                    character.charEquipmentLoadOut[1] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "HELM") 
                {
                    if (character.charEquipmentLoadOut[2].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[2]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(2);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[2] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "BODY")
                {
                    if (character.charEquipmentLoadOut[3].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[3]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(3);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[3] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "FEET")
                {
                    if (character.charEquipmentLoadOut[4].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[4]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(4);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[4] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "NECK")
                {
                    if (character.charEquipmentLoadOut[5].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[5]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(5);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[5] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "RIGHT RING" || userInput.ToUpper() == "RIGHTRING" || userInput.ToUpper() == "RR" || userInput.ToUpper() == "RRING" || userInput.ToUpper() == "RINGR" || userInput.ToUpper() == "RING R")
                {
                    if (character.charEquipmentLoadOut[6].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[6]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(6);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[6] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }
                else if (userInput.ToUpper() == "LEFT RING" || userInput.ToUpper() == "LEFTRING" || userInput.ToUpper() == "LR" || userInput.ToUpper() == "LRING" || userInput.ToUpper() == "RINGL" || userInput.ToUpper() == "RING L")
                {
                    if (character.charEquipmentLoadOut[7].ToUpper() != "EMPTY")
                    {
                        bool inventoryLoopFlag2 = true;
                        bool wasItemUnEquipped = false;

                        while (inventoryLoopFlag2 == true)
                        {
                            Console.Clear();

                            ItemAttributeList.DisplayItemAttributes(character.charEquipmentLoadOut[7]);

                            Console.WriteLine("\nWould you like to unequip this item?");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                wasItemUnEquipped = character.UnEquipUseBehavior2(7);

                                if (wasItemUnEquipped == true)
                                {
                                    character.charEquipmentLoadOut[7] = "Empty";
                                }

                                inventoryLoopFlag2 = false;

                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                inventoryLoopFlag2 = false;

                                Console.Clear();

                                Console.WriteLine("Returning to inventory...");

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
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"This equipment slot is empty.");

                        Thread.Sleep(1000);
                    }
                }

                #endregion

                else if (userInput.ToUpper() == "QUIT" || userInput.ToUpper() == "Q")
                {
                    Console.Clear();

                    Console.WriteLine("Closing Inventory...");

                    Thread.Sleep(1000);

                    inventoryLoopFlag = false;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("You have chosen an invalid selection smoothbrain.");

                    Thread.Sleep(1000);
                }

                character.SetDerivedAttributes(character.charClass);
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
                Console.WriteLine($"{ItemAttributeList.breastplateName} - Price : {ItemAttributeList.breastplateValue}");
                Console.WriteLine($"{ItemAttributeList.steelBootsName} - Price : {ItemAttributeList.steelBootsValue}");
                Console.WriteLine($"{ItemAttributeList.longswordName} - Price : {ItemAttributeList.longswordValue}");

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

                            if (assignedInventoryPosition != 999)
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

                            if (assignedInventoryPosition != 999)
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

                            if (assignedInventoryPosition != 999)
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

                            if (assignedInventoryPosition != 999)
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

                            if (assignedInventoryPosition != 999)
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

                            if (assignedInventoryPosition != 999)
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
                else if (userInput.ToUpper() == "BREASTPLATE")
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.breastplateName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition != 999)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.breastplateName;

                                Console.WriteLine($"\n{ItemAttributeList.breastplateName} was placed in slot {assignedInventoryPosition + 1}");

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
                else if (userInput.ToUpper() == "STEEL BOOTS" || userInput.ToUpper() == "STEELBOOTS")
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.steelBootsName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition != 999)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.steelBootsName;

                                Console.WriteLine($"\n{ItemAttributeList.steelBootsName} was placed in slot {assignedInventoryPosition + 1}");

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
                else if (userInput.ToUpper() == "LONGSWORD") 
                {
                    bool shopLoop2 = true;

                    while (shopLoop2 == true)
                    {
                        Console.Clear();

                        ItemAttributeList.DisplayItemAttributes(ItemAttributeList.longswordName);
                        Console.WriteLine("\nDo you want to buy this?");

                        userInput = Console.ReadLine();

                        if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                        {
                            Console.Clear();

                            Console.WriteLine("Let's get this wrapped up and in your inventory shall we?");

                            int assignedInventoryPosition = character.AutoPickUpValidInventorySlotCheck();

                            if (assignedInventoryPosition != 999)
                            {
                                character.charInventory[assignedInventoryPosition] = ItemAttributeList.longswordName;

                                Console.WriteLine($"\n{ItemAttributeList.longswordName} was placed in slot {assignedInventoryPosition + 1}");

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
            bool userInputVerificationFlag;
            bool yesOrNoLoopFlag;
            bool heightWeightAgeLoopFlag;
            string userInput;
            string[] playerCharacterInformation = new string[13];

            playerCharacterInformation[12] = "true";

            do // Main loop for entire process
            {                
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

                    if (userInput.Length <= 15 && String.IsNullOrEmpty(userInput) == false)
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
                        playerCharacterInformation[1] = CharacterRaces.raceList[0];

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

                                    Console.Write($"Is {playerCharacterInformation[2]} the height you want? ");

                                    userInput = Console.ReadLine();

                                    if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                                    {
                                        userInputVerificationFlag = false;
                                        yesOrNoLoopFlag = false;

                                        Console.Clear();

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

                                        Console.WriteLine($"{userInput} is not a valid selection.");

                                        Thread.Sleep(1000);
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
                                playerCharacterInformation[3] = Convert.ToString(CharacterRaces.WeightChecker(playerCharacterInformation[1], Convert.ToInt32(userInput)));

                                do
                                {
                                    Console.Clear();

                                    Console.Write($"Is {playerCharacterInformation[3]} the weight you want? ");

                                    userInput = Console.ReadLine();

                                    if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                                    {
                                        userInputVerificationFlag = false;
                                        yesOrNoLoopFlag = false;

                                        Console.Clear();

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

                                        Console.WriteLine($"{userInput} is not a valid selection.");

                                        Thread.Sleep(1000);
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
                                playerCharacterInformation[4] = Convert.ToString(CharacterRaces.AgeChecker(playerCharacterInformation[1], Convert.ToInt32(userInput)));

                                do
                                {
                                    Console.Clear();

                                    Console.Write($"Is {playerCharacterInformation[4]} the age you want? ");

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

                                        Console.WriteLine($"{userInput} is not a valid selection.");

                                        Thread.Sleep(1000);
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

                } while (heightWeightAgeLoopFlag == true); // End of overarching height, weight, age loop

                do // Start of attribute setting loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    if (playerCharacterInformation[1].ToUpper() == "HUMAN")
                    {
                        int attributePoints = CharacterRaces.humStartingAttributePoints;
                        string userAttributeInput;

                        int startingAttributeTotal = CharacterRaces.humStartingAttributes[0] + CharacterRaces.humStartingAttributes[1] + CharacterRaces.humStartingAttributes[2] + CharacterRaces.humStartingAttributes[3] + CharacterRaces.humStartingAttributes[4] + CharacterRaces.humStartingAttributes[5];
                        int finalAttributeTotal = startingAttributeTotal + attributePoints;
                        int[] currAttributes = { CharacterRaces.humStartingAttributes[0], CharacterRaces.humStartingAttributes[1], CharacterRaces.humStartingAttributes[2], CharacterRaces.humStartingAttributes[3], CharacterRaces.humStartingAttributes[4], CharacterRaces.humStartingAttributes[5] };
                        int currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5];

                        Console.Clear();

                        Console.WriteLine("Now to set your starting attributes.");

                        Thread.Sleep(1000);

                        do
                        {
                            Console.Clear();

                            Console.WriteLine($"Current Attributes" +
                                $"\n\nSTR : {currAttributes[0]}" +
                                $"\nDEX : {currAttributes[1]}" +
                                $"\nCON : {currAttributes[2]}" +
                                $"\nINT : {currAttributes[3]}" +
                                $"\nWIS : {currAttributes[4]}" +
                                $"\nCHA : {currAttributes[5]}");

                            Console.WriteLine($"\nYou have {attributePoints} attribute points remaining...");

                            Console.Write("\nSelect an attribute you would like to change : ");

                            userAttributeInput = Console.ReadLine();

                            if (userAttributeInput.ToUpper() == "STR" || userAttributeInput.ToUpper() == "STRENGTH")
                            {
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[0]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[0]},{CharacterRaces.humStartingMaxAttributes[0]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

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
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[1]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[1]},{CharacterRaces.humStartingMaxAttributes[1]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == true)
                                {
                                    if (Convert.ToInt32(userInput) <= attributePoints)
                                    {
                                        currAttributes[1] = currAttributes[1] + Convert.ToInt32(userInput);

                                        currAttributes[1] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[1]);
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
                            else if (userAttributeInput.ToUpper() == "CON" || userAttributeInput.ToUpper() == "CONSTITUTION")
                            {
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[2]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[2]},{CharacterRaces.humStartingMaxAttributes[2]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == true)
                                {
                                    if (Convert.ToInt32(userInput) <= attributePoints)
                                    {
                                        currAttributes[2] = currAttributes[2] + Convert.ToInt32(userInput);

                                        currAttributes[2] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[2]);
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
                            else if (userAttributeInput.ToUpper() == "INT" || userAttributeInput.ToUpper() == "INTELLIGENCE")
                            {
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[3]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[3]},{CharacterRaces.humStartingMaxAttributes[3]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == true)
                                {
                                    if (Convert.ToInt32(userInput) <= attributePoints)
                                    {
                                        currAttributes[3] = currAttributes[3] + Convert.ToInt32(userInput);

                                        currAttributes[3] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[3]);
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
                            else if (userAttributeInput.ToUpper() == "WIS" || userAttributeInput.ToUpper() == "WISDOM")
                            {
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[4]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[4]},{CharacterRaces.humStartingMaxAttributes[4]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == true)
                                {
                                    if (Convert.ToInt32(userInput) <= attributePoints)
                                    {
                                        currAttributes[4] = currAttributes[4] + Convert.ToInt32(userInput);

                                        currAttributes[4] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[4]);
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
                            else if (userAttributeInput.ToUpper() == "CHA" || userAttributeInput.ToUpper() == "CHARISMA")
                            {
                                Console.Clear();

                                Console.WriteLine($"Current {userAttributeInput.ToUpper()} : {currAttributes[5]}   Racial Min,Max : {CharacterRaces.humStartingMinAttributes[5]},{CharacterRaces.humStartingMaxAttributes[5]}");

                                Console.WriteLine($"\nYou have {attributePoints} points to spend...");

                                Console.Write($"\nHow much would you like to change {userAttributeInput.ToUpper()} by : ");

                                userInput = Console.ReadLine();

                                if (UserInputVerifications.IsNumber(userInput) == true)
                                {
                                    if (Convert.ToInt32(userInput) <= attributePoints)
                                    {
                                        currAttributes[5] = currAttributes[5] + Convert.ToInt32(userInput);

                                        currAttributes[5] = CharacterRaces.AttributeChecker(playerCharacterInformation[1], userAttributeInput, currAttributes[5]);
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
                            else
                            {
                                Console.Clear();

                                Console.WriteLine($"{userAttributeInput} is not a valid choice.");

                                Thread.Sleep(1000);
                            }

                            currAttributesTotal = currAttributes[0] + currAttributes[1] + currAttributes[2] + currAttributes[3] + currAttributes[4] + currAttributes[5]; // I keep making this mistake, need these here to properly update for while condition
                            attributePoints = finalAttributeTotal - currAttributesTotal;

                        } while (attributePoints != 0);

                        do
                        {
                            Console.Clear();

                            Console.WriteLine($"Current Attributes" +
                                    $"\n\nSTR : {currAttributes[0]}" +
                                    $"\nDEX : {currAttributes[1]}" +
                                    $"\nCON : {currAttributes[2]}" +
                                    $"\nINT : {currAttributes[3]}" +
                                    $"\nWIS : {currAttributes[4]}" +
                                    $"\nCHA : {currAttributes[5]}");

                            Console.Write("\nAre you okay with these attributes? ");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                userInputVerificationFlag = false;
                                yesOrNoLoopFlag = false;

                                Console.Clear();

                                Console.WriteLine("Finalizing setting of all attributes...");

                                Thread.Sleep(1000);

                                playerCharacterInformation[5] = Convert.ToString(currAttributes[0]);
                                playerCharacterInformation[6] = Convert.ToString(currAttributes[1]);
                                playerCharacterInformation[7] = Convert.ToString(currAttributes[2]);
                                playerCharacterInformation[8] = Convert.ToString(currAttributes[3]);
                                playerCharacterInformation[9] = Convert.ToString(currAttributes[4]);
                                playerCharacterInformation[10] = Convert.ToString(currAttributes[5]);
                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                yesOrNoLoopFlag = false;

                                Console.Clear();

                                Console.WriteLine("No? Then let's start over.");

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

                        Console.WriteLine("An invalid race has been selected. Terminating program...");

                        Thread.Sleep(1000);

                        Environment.Exit(0);
                    }
                } while (userInputVerificationFlag == true); // End of attribute setting loop

                do // Start of Class setting loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    Console.Clear();

                    Console.WriteLine("Now you must select a starting class." +
                        "\n\nClass List\n");

                    UserInputFunctions.ListAllElements(CharacterClasses.classList);

                    Console.Write("\nWhat class do you choose? ");

                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "FIGHTER")
                    {
                        do
                        {
                            playerCharacterInformation[11] = CharacterClasses.classList[0];

                            Console.Clear();

                            CharacterClasses.DisplayClassInformation(userInput);

                            Console.Write("\nIs this the class you wanted to select? ");

                            userInput = Console.ReadLine();

                            if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                            {
                                userInputVerificationFlag = false;
                                yesOrNoLoopFlag = false;

                                Console.Clear();

                                Console.WriteLine("Finalizing class choice...");

                                Thread.Sleep(1000);
                            }
                            else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                            {
                                yesOrNoLoopFlag = false;

                                Console.Clear();

                                Console.WriteLine("No? Then let's try again.");

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

                        Console.WriteLine($"{userInput} is not a valid class.");

                        Thread.Sleep(1000);
                    }

                } while (userInputVerificationFlag == true); // End of class setting loop

                do // Finalizing loop
                {
                    userInputVerificationFlag = true;
                    yesOrNoLoopFlag = true;

                    Console.Clear();

                    Console.WriteLine("Final Character");

                    Console.WriteLine("\nName : " + playerCharacterInformation[0] +
                        "\nRace : " + playerCharacterInformation[1] +
                        "\n\nHeight(cm) : " + playerCharacterInformation[2] +
                        "\nWeight(lb) : " + playerCharacterInformation[3] +
                        "\nAge(yrs) : " + playerCharacterInformation[4] +
                        "\n\nClass : " + playerCharacterInformation[11] +
                        "\n\nSTR : " + playerCharacterInformation[5] +
                        "\nDEX : " + playerCharacterInformation[6] +
                        "\nCON : " + playerCharacterInformation[7] +
                        "\nINT : " + playerCharacterInformation[8] +
                        "\nWIS : " + playerCharacterInformation[9] +
                        "\nCHA : " + playerCharacterInformation[10]);

                    Console.Write("\nIs this who you wanted to make? ");

                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "YES" || userInput.ToUpper() == "Y")
                    {
                        userInputVerificationFlag = false;
                        yesOrNoLoopFlag = false;

                        Console.Clear();

                        Console.WriteLine($"Finalizing creation of {playerCharacterInformation[0]} the {playerCharacterInformation[1]} {playerCharacterInformation[11]}");

                        Thread.Sleep(1000);

                        Console.WriteLine("\nCharacter created! Press any key to continue...");

                        Console.ReadKey();
                    }
                    else if (userInput.ToUpper() == "NO" || userInput.ToUpper() == "N")
                    {
                        yesOrNoLoopFlag = false;

                        Console.Clear();

                        Console.WriteLine("No? Let's take it from the top then.");

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine($"{userInput} is not a valid selection.");

                        Thread.Sleep(1000);
                    }

                } while (yesOrNoLoopFlag == true); // End of finalizing loop

            } while (userInputVerificationFlag == true);

            return playerCharacterInformation;
        }
    }
}   


