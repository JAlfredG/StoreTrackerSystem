namespace STSBusinessDataLogic
{
    public class STSProcess
    {
        static string userName = "admin", password = "admin";
        static short loginAttempts = 0;
        public static List<string> inventory = new List<string>();

        public static bool LogInValid(string userInput, string passInput)
        {
             return userInput == userName && passInput == password;
        }

        public static bool LogInAttempts()
        {
            loginAttempts++;

            if(loginAttempts == 5)
            {
                loginAttempts = 0;
                return true;
            }

            return false;
        }

        public static bool CheckInventory()
        {
            return inventory.Count != 0;
        }

        public static string UpdateInventory(Actions userAction, string item)
        {
            if (userAction == Actions.AddItem)
            {
                inventory.Add(item);
            }
            else if (userAction == Actions.RemoveItem)
            {
                inventory.Remove(item);
            }
            return item;
        }
    }
}
