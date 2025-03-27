namespace STSBusinessDataLogic
{
    public class STSProcess
    {
        public static string userName, password;
        public static List<string> inventory = new List<string>();
        public static bool LogInValid()
        {
             return userName == "admin" && password == "admin";
        }

        public static bool CheckInventory()
        {
            return inventory.Count != 0;
        }
    }
}
