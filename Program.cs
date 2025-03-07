﻿namespace StoreTrackerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables used
            string userName, password;
            bool loginLoop = false, optionLoop = false;
            char opt;

            Console.WriteLine("Welcome to Store Tracker");

            //loop until login is successful
            while (!loginLoop)
            {
                //get username and password
                Console.WriteLine("Username: ");
                userName = Console.ReadLine();
                Console.WriteLine("Password: ");
                password = Console.ReadLine();

                //check if username and password are correct
                if (userName == "admin" && password == "admin")
                {
                    Console.WriteLine("Login Successful");

                    //loop the option
                    while (!optionLoop)
                    {
                        //show options
                        Console.WriteLine("""
                            [1] View Inventory
                            [2] Update Inventory
                            [3] View Last Daily Report
                            [4] Create Daily Report
                            [5] View Last Earning Report
                            [6] Create Earning Report
                            [7] Exit
                            """);
                        opt =Convert.ToChar(Console.ReadLine());

                        //function depending on choice made
                        switch(opt)
                        {
                            case '1':
                                Console.WriteLine("View Inventory");
                                //view current inventory
                                break;
                            case '2':
                                Console.WriteLine("Update Inventory");
                                /*
                                add item
                                remove item
                                update quantity of each item
                                 */
                                break;
                            case '3':
                                Console.WriteLine("View Last Daily Report");
                                //show the last daily report
                                break;
                            case '4':
                                Console.WriteLine("Create Daily Report");
                                //create a daily report for that day
                                break;
                            case '5':
                                Console.WriteLine("View Last Earning Report");
                                //show the last earning report
                                break;
                            case '6':
                                Console.WriteLine("Create Earning Report");
                                //create an earning report which includes earnings, lost, and profit
                                break;
                            case '7':
                                //exit the program
                                optionLoop = true;
                                break;
                            default:
                                Console.WriteLine("Invalid Option");
                                break;
                        }
                    }
                    loginLoop = true;
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                }
            }                       
        }
    }
}
