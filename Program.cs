namespace StoreTrackerSystem
{
    internal class Program
    {
        //global variables
        static byte systemOption, inventoryOption;
        static string dailyReport = null, earningsReport = null, updateDailyReport, updateEarningsReport, inventoryItem;
        static List<string> inventory = new List<string>();
        static void Main(string[] args)
        {
            //local variables
            string userName, password;
            bool loginLoop = false;
            short loginAttempts = 0;
            
            Console.WriteLine("Welcome to Store Tracker!");

            //loop until login is successful
            while (!loginLoop)
            {
                //get username and password
                Console.Write("Username: ");
                userName = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();

                //check if username and password are correct
                if (userName == "admin" && password == "admin")
                {
                    Console.WriteLine("Login Successful!\n");

                    //show options/functions on loop
                    do
                    {
                        ShowSystemOptions();

                        //function depending on choice made
                        switch (systemOption)
                        {
                            case 1:
                                Inventory(1); //view inventory
                                break;
                            case 2:
                                Inventory(2); //update inventory
                                break;
                            case 3:
                                DailyReport(3); //show the last daily report
                                break;
                            case 4:
                                DailyReport(4); //create a daily report for that day
                                break;
                            case 5:
                                EarningReport(5); //show the last earning report
                                break;
                            case 6:
                                EarningReport(6); //create earnings report
                                break;
                            case 7:
                                //exit the program
                                Console.WriteLine("Thank you for using our program!");
                                break;
                            default:
                                Console.WriteLine("Invalid Option");
                                break;
                        }
                        Console.WriteLine();
                    } while (systemOption != 7);
                    loginLoop = true;
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password.");
                    loginAttempts++;

                    if (loginAttempts == 5)
                    {
                        Console.WriteLine("Too many attempts. Please try again later.");
                        loginAttempts = 0;
                        loginLoop = true;
                    }
                }
            }                       
        }

        static void ShowSystemOptions()
        {
            //show options
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

        static void Inventory(byte userChoice)
        {
            if (userChoice == 1)
            {
                if (inventory.Count!=0)
                {
                    Console.WriteLine("Current Inventory:");
                    showInventory();
                }
                else
                {
                    Console.WriteLine("Inventory is empty.");
                }

            }

            if (userChoice == 2)
            {
                string itemRemove;

                Console.WriteLine("\nUpdate Inventory:");
                //show the list of inventory in array form
                Console.Write("""
                    [1] Add Item
                    [2] Remove Item
                    UserInput: 
                    """);
                inventoryOption = Convert.ToByte(Console.ReadLine());

                if (inventoryOption == 1)
                {
                    Console.Write("Add Item to Inventory: ");
                    inventoryItem = Console.ReadLine();
                    inventory.Add(inventoryItem);
                    Console.WriteLine("Current Invetory: ");
                    showInventory();
                }
                else if (inventoryOption == 2)
                {
                    if (inventory.Count != 0)
                    {
                        Console.WriteLine("Current Inventory: ");
                        showInventory();

                        Console.Write("Item name to be removed: ");
                        itemRemove = Console.ReadLine();

                        if (inventory.Contains(itemRemove))
                        {
                            Console.WriteLine($"\n'{itemRemove}' removed from the inventory.");
                            inventory.Remove(itemRemove);

                            Console.WriteLine("Current Inventory: ");
                            showInventory();
                            Console.WriteLine();
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
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }

        static void DailyReport(byte userChoice)
        {
            if (userChoice == 3)
            {
                if (dailyReport == null)
                {
                    Console.WriteLine("No current report.");
                }
                else
                {
                    updateDailyReport = dailyReport;
                    Console.WriteLine($"Last Daily Report: {updateDailyReport}");
                }

            }
            else if (userChoice == 4)
            {
                Console.Write("Create Daily Report: ");
                dailyReport = Console.ReadLine();
                Console.WriteLine("Report Updated.");
                Console.WriteLine($"Last Daily Report: {dailyReport}");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

        }

        static void EarningReport(byte userChoice)
        {
            if(userChoice == 5)
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

            else if (userChoice == 6)
            {
                Console.Write("Create Earnings Report: ");
                dailyReport = Console.ReadLine();
                Console.WriteLine("Report Updated.");
                Console.WriteLine($"Last Earnings Report: {earningsReport}");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        static void showInventory()
        {
            foreach (string items in inventory)
            {
                Console.WriteLine("\t" + items);
            }
        }
        
    }   
}
