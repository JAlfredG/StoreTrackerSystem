using STSBusinessDataLogic;

namespace StoreTrackerSystem
{
    internal class Program
    {
        static byte systemOption, inventoryOption;
        static string earningsReport = null, updateEarningsReport, inventoryItem;

        static void Main(string[] args)
        {
            string userName, password;
            
            Console.WriteLine("Welcome to Store Tracker!");
            
            //log in frame
            do
            {
                Console.Write("Username: ");
                userName = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();

                if(!LogInFunction.LogInValid(userName, password))
                {
                    Console.WriteLine("Invalid Username or Password.");

                    if (LogInFunction.LogInAttempts())
                    {
                        Console.WriteLine("Too many attempts. Please try again later.");
                        return;
                    }
                }
            } while (!LogInFunction.LogInValid(userName, password));

            Console.WriteLine("Login Successful!\n");
            //system options
            do
            {
                try
                {
                    ShowSystemOptions();
                    switch (systemOption)
                    {
                        case 1:
                            viewInventory(); //view inventory
                            break;
                        case 2:
                            updateInventory(); //update inventory
                            break;
                        case 3:
                            viewDailyReport(); //show the last daily report
                            break;
                        case 4:
                            createDailyReport(); //create a daily report for that day
                            break;
                        case 5:
                            viewEarningReport(); //show the last earning report
                            break;
                        case 6:
                            createEarningReport(); //create earnings report
                            break;
                        case 7:
                            Console.WriteLine("Thank you for using our program!"); //exit the program
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("Invalid input.");
                }
                Console.WriteLine();
            } while (systemOption != 7);
        }

        static void ShowSystemOptions()
        {
            Console.Write("""
                            [1] View Inventory
                            [2] Update Inventory
                            [3] View Last Daily Report
                            [4] Create Daily Report
                            [5] View Last Earning Report
                            [6] Create Earning Report
                            [7] Exit
                            UserInput: 
                            """);
            systemOption = Convert.ToByte(Console.ReadLine());
        }

        static void viewInventory()
        {
            if (InventoryManagementBL.CheckInventory())
            {
                showInventory();
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }

        static void updateInventory()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Store Tracker!");
            do
            {
                Console.WriteLine("\nUpdate Inventory:");
                Console.Write("""
                [1] Add Item
                [2] Remove Item
                [3] Update Item Quantity
                [4] Back
                UserInput: 
                """);
                inventoryOption = Convert.ToByte(Console.ReadLine());

                if (inventoryOption == 1)
                {
                    inventoryAddItem();
                }
                else if (inventoryOption == 2)
                {
                    inventoryRemoveItem();
                }
                else if(inventoryOption == 3)
                {
                    updateItemQuantity();
                }
                else if (inventoryOption == 4)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            } while (inventoryOption != 4);
        }

        static void showInventory()
        {
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("\tItem name : Quantity");
            foreach (var items in InventoryManagementBL.inventory)
            {
                Console.WriteLine($"\t{items.Key} : {items.Value}");
            }
        }

        static void inventoryAddItem()
        {
            showInventory();
            Console.Write("Add Item to Inventory: ");
            inventoryItem = Console.ReadLine().Trim().ToLower();
            Console.Write("Item Quantity: ");
            InventoryManagementBL.itemQuantity = Convert.ToInt32(Console.ReadLine());

            if (InventoryManagementBL.CheckItemQuantity() && !InventoryManagementBL.CheckItemInInventory(inventoryItem))
            {
                InventoryManagementBL.UpdateInventory(Actions.AddItem, inventoryItem);
                showInventory();
            }
            else
            {
                Console.WriteLine("Either item already exist in the inventory or invalid quantity.");
            }
        }

        static void inventoryRemoveItem()
        {
            if (InventoryManagementBL.CheckInventory())
            {
                showInventory();
                Console.Write("Item name to be removed: ");
                inventoryItem = Console.ReadLine().Trim().ToLower();

                if (InventoryManagementBL.CheckItemInInventory(inventoryItem))
                {
                    Console.WriteLine($"\n'{inventoryItem}' removed from the inventory.");
                    InventoryManagementBL.UpdateInventory(Actions.RemoveItem, inventoryItem);
                    showInventory();
                }
                else
                {
                    Console.WriteLine("Either item name is incorrect or item does not exist on the list.");
                }
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }

        static void updateItemQuantity()
        {
            if (InventoryManagementBL.CheckInventory())
            {
                showInventory();
                Console.Write("Input item name: ");
                inventoryItem = Console.ReadLine().Trim().ToLower();
                Console.Write("Input new item quantity: ");
                InventoryManagementBL.itemQuantity = Convert.ToInt32(Console.ReadLine());

                if (InventoryManagementBL.CheckItemInInventory(inventoryItem) && InventoryManagementBL.CheckItemQuantity())
                {
                    InventoryManagementBL.UpdateInventory(Actions.UpdateQuantity, inventoryItem);
                    showInventory();
                }
                else
                {
                    Console.WriteLine("Either item name is incorrect, item does not exist on the list, or invalid item quantity.");
                }
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }

        }

        static void viewDailyReport()
        {
            if (DailyReportBL.CheckDailyReport())
            {
                Console.WriteLine($"Last Daily Report: {DailyReportBL.dailyReport}");
            }
            else
            {
                Console.WriteLine("No current report.");
            }
        }

        static void createDailyReport()
        {
            Console.Write("Create Daily Report: ");
            DailyReportBL.createDailyReport(Console.ReadLine());
            Console.WriteLine("Report Updated.");
            Console.WriteLine($"Daily Report: {DailyReportBL.dailyReport}");
        }

        static void viewEarningReport()
        {
            if (earningsReport == null)
            {
                Console.WriteLine("No current report.");
            }
            else
            {
                updateEarningsReport = earningsReport;
                Console.WriteLine($"Last Earnings Report: {updateEarningsReport}");
            }
        }

        static void createEarningReport()
        {
            Console.Write("Create Earnings Report: ");
            earningsReport = Console.ReadLine();
            Console.WriteLine("Report Updated.");
            Console.WriteLine($"Earnings Report: {earningsReport}");
        }
        
    }   
}