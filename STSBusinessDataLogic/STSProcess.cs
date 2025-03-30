namespace STSBusinessDataLogic
{
    public class STSProcess
    {
        static string userName = "admin", password = "admin";
        static short loginAttempts = 0;
        public static int itemQuantity;
        public static Dictionary<string, int> inventory = new Dictionary<string, int>();
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
            return inventory.Count > 0;
        }

        public static bool CheckItemQuantity()
        {
            return itemQuantity > 0;
        }

        public static bool CheckItemInInventory(string item)
        {
            if (inventory.ContainsKey(item))
            {
                return true;
            }
            return false;
        }

        public static string UpdateInventory(Actions userAction, string item)
        {
            if (userAction == Actions.AddItem)
            {
                inventory.Add(item, itemQuantity);
            }
            else if (userAction == Actions.RemoveItem)
            {
                inventory.Remove(item);
            }
            else if (userAction == Actions.UpdateQuantity)
            {
                inventory[item] = itemQuantity;
            }
                return item;
        }
    }
}
