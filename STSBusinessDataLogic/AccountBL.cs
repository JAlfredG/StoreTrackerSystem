using STSDataService;

namespace STSBusinessDataLogic
{
    public class AccountBL
    {

        STSAccountData accountData = new STSAccountData();
        static short loginAttempts = 0;

        public bool LogInValid(string userInput, string passInput)
        {
            return accountData.ValidateUserAccount(userInput, passInput);
        }

        public bool LogInAttempts()
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
