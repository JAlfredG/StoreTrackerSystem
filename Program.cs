namespace StoreTrackerSystem
{
    internal class Program
    {
        //global variables
        static byte systemOption;
        static string dailyReport = "No current report", updateDailyReport;
        static void Main(string[] args)
        {
            //local variables
            string userName, password;
            bool loginLoop = false;
            
            Console.WriteLine("Welcome to Store Tracker");

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
                        ShowOptions();

                        //function depending on choice made
                        switch (systemOption)
                        {
                            case 1:
                                Console.WriteLine("View Inventory"); //view current inventory
                                break;
                            case 2:
                                Console.WriteLine("Update Inventory");
                                //show options for inventory; 1 frame - scroll pane - add/remove item - textfield

                                /*
                                add item
                                remove item
                                update quantity of each item
                                 */
                                break;
                            case 3:
                                DailyReport(3); //show the last daily report
                                break;
                            case 4:
                                DailyReport(4); //create a daily report for that day
                                break;
                            case 5:
                                Console.WriteLine("View Last Earning Report");
                                //show the last earning report
                                break;
                            case 6:
                                Console.WriteLine("Create Earning Report");
                                //1 frame - textfields for earnings, profit (money update)
                                //create an earning report which includes earnings, lost, and profit
                                break;
                            case 7:
                                //exit the program
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
                    Console.WriteLine("Invalid Username or Password");
                }
            }                       
        }

        static void ShowOptions()
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

        static void DailyReport(byte userChoice)
        {
            if(userChoice == 3)
            {
                updateDailyReport = dailyReport;
                Console.WriteLine($"Last Daily Report: {updateDailyReport}");
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
    }   
}
