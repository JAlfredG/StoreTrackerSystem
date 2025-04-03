namespace STSBusinessDataLogic
{
    public class LogInFunction
    {
        static string userName = "admin", password = "admin";
        static short loginAttempts = 0;
        
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
        
    }
}
