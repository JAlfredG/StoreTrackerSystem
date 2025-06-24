using STSCommon;
using STSDataService;

namespace STSBusinessDataLogic
{
    public class AccountBL
    {

        AccountSTSData accountData = new AccountSTSData();
        static short loginAttempts = 0;

        public bool LogInValid(string userInput, string passInput)
        {
            var account = GetSTSAccount(userInput, passInput);

            if (account.UserName != null)
            {
                return true;
            }

            return false;
        }

        private StoreAccount GetSTSAccount(string username, string password)
        {
            var STSAccounts = accountData.GetAllAccounts();
            var accountFound = new StoreAccount();

            foreach (var account in STSAccounts)
            {
                if (account.UserName == username && account.Password == password)
                {
                    accountFound = account;
                }
            }
            return accountFound;
        }

        public List<StoreAccount> GetStoreAccounts()
        {
            return accountData.GetAllAccounts();
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
