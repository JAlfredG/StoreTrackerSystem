using STSBusinessDataLogic;

namespace StoreTrackerSystem
{
    internal class Program
    {
        static byte systemOption, inventoryOption;
        static string inventoryItem;
        static double itemPrice;
        static int itemQuantity;
        static STSBusinessDataLogic.AccountBL accountService = new STSBusinessDataLogic.AccountBL();

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

                if(!accountService.LogInValid(userName, password))
                {
                    Console.WriteLine("Invalid Username or Password.");

                    if (accountService.LogInAttempts())
                    {
                        Console.WriteLine("Too many attempts. Please try again later.");
                        return;
                    }
                }
            } while (!accountService.LogInValid(userName, password));

            Console.WriteLine("Login Successful!\n");
            //system options
            do
            {
                try
                {
                    showSystemOptions();
                    switch (systemOption)
                    {
                        case 1:
                            viewInventory(); //view inventory
                            break;
                        case 2:
                            viewDailyReport(); //show the last daily report
                            break;
                        case 3:
                            viewSalesReport(); //show the last earning report
                            break;
                        case 4:
                            updateInventory(); //update inventory
                            break;
                        case 5:
                            createDailyReport(); //create a daily report for that day
                            break;
                        case 6:
                            createSalesReport(); //create earnings report
                            break;
                        case 7:
                            Console.WriteLine("Thank you for using our program!"); //exit the program
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                }
                Console.WriteLine();
            } while (systemOption != 7);
        }

        static void showSystemOptions()
        {
            Console.Write("""
                            [1] View Inventory
                            [2] View Daily Report
                            [3] View Sales Report
                            [4] Update Inventory
                            [5] Create Daily Report
                            [6] Create Sales Report
                            [7] Exit
                            UserInput: 
                            """);
            systemOption = Convert.ToByte(Console.ReadLine());
        }

        static void updateInventory()
        {
            Console.Clear();
            do
            {
                Console.WriteLine("\nUpdate Inventory:");
                Console.Write("""
                [1] Show Inventory
                [2] Add Item
                [3] Remove Item
                [4] Update Item Quantity
                [5] Update Item Price
                [6] Back
                UserInput: 
                """);
                inventoryOption = Convert.ToByte(Console.ReadLine());

                switch (inventoryOption)
                {
                    case 1:
                        viewInventory();
                        break;
                    case 2:
                        inventoryAddItem();
                        break;
                    case 3:
                        inventoryRemoveItem();
                        break;
                    case 4:
                        updateItemQuantity();
                        break;
                    case 5:
                        updateItemPrice();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (inventoryOption != 6);
        }

        static void viewInventory()
        {

            if (InventoryBL.CheckInventory())
            {
                Console.WriteLine("Current Inventory: ");
                Console.WriteLine("\tItem name \t: Quantity \t: Price");
                foreach (var items in InventoryBL.GetInventory())
                {
                    Console.WriteLine($"\t{items.ItemName} \t\t: {items.ItemQuantity} \t\t: {items.ItemPrice} pesos");
                }
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }

        static void inventoryAddItem()
        {
            Console.Write("Add Item to Inventory: ");
            inventoryItem = Console.ReadLine().Trim();
            Console.Write("Item Quantity: ");
            itemQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item Price: ");
            itemPrice = Convert.ToDouble(Console.ReadLine());

            if (InventoryBL.CheckItemQuantity(itemQuantity) && !InventoryBL.CheckItemInInventory(inventoryItem))
            {
                InventoryBL.AddItem(inventoryItem, itemPrice, itemQuantity);
                Console.WriteLine($"\n '{inventoryItem}' added to the inventory.");
            }
            else
            {
                Console.WriteLine("Either item already exist in the inventory or invalid quantity.");
            }
        }

        static void inventoryRemoveItem()
        {
            if (InventoryBL.CheckInventory())
            {
                viewInventory();
                Console.Write("Item name to be removed: ");
                inventoryItem = Console.ReadLine().Trim();

                if (InventoryBL.CheckItemInInventory(inventoryItem))
                {
                    Console.WriteLine($"\n'{inventoryItem}' removed from the inventory.");
                    InventoryBL.RemoveItem(inventoryItem);
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
            if (InventoryBL.CheckInventory())
            {
                viewInventory();
                Console.Write("Input item name: ");
                inventoryItem = Console.ReadLine().Trim();
                Console.Write("Input new item price: ");
                itemQuantity = Convert.ToInt32(Console.ReadLine());

                if (InventoryBL.CheckItemInInventory(inventoryItem) && InventoryBL.CheckItemQuantity(itemQuantity))
                {
                    InventoryBL.UpdateQuantity(inventoryItem, itemQuantity);
                    Console.WriteLine($"\n'{inventoryItem}' quantity updated.");
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

        static void updateItemPrice()
        {
            if (InventoryBL.CheckInventory())
            {
                viewInventory();
                Console.Write("Input item name: ");
                inventoryItem = Console.ReadLine().Trim();
                Console.Write("Input new item price: ");
                itemPrice = Convert.ToDouble(Console.ReadLine());

                if (InventoryBL.CheckItemInInventory(inventoryItem))
                {
                    InventoryBL.UpdatePrice(inventoryItem, itemPrice);
                    Console.WriteLine($"\n'{inventoryItem}' price updated.");
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
            DailyReportBL.CreateDailyReport(Console.ReadLine());
            Console.WriteLine("Report Updated.");
            Console.WriteLine($"Daily Report: {DailyReportBL.dailyReport}");
        }


        static void viewSalesReport()
        {
            if (!SalesReportBL.IsInitialProfitUnset())
            {
                SalesReportBL.CalculateProfitDifference();
                SalesReportBL.CalculateProfitPercentage();

                Console.WriteLine($"Initial Profit: {SalesReportBL.initialProfit}");
                Console.WriteLine($"Today's Profit: {SalesReportBL.newProfit}");
                Console.WriteLine($"Profit Difference: {SalesReportBL.difference}");
                Console.WriteLine($"Profit Percentage: {SalesReportBL.percentage:F2}%");
            }
            else
            {
                Console.WriteLine("No current report.");
            }

        }

        static void createSalesReport()
        {
            Console.Write("Input today's profit: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (SalesReportBL.IsInitialProfitUnset())
            {
                SalesReportBL.initialProfit = input;
            }
            else if (SalesReportBL.IsNewProfitUnset())
            {
                SalesReportBL.newProfit = input;
            }
            else
            {
                SalesReportBL.tempProfit = input;
                SalesReportBL.UpdateProfit();
            }

            Console.WriteLine("Report Updated successfully.\n");
        }
    }   
}