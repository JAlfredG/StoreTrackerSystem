using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{
    public class STSAccountData
    {
        List<StoreAccount> accounts = new List<StoreAccount>();
        public STSAccountData()
        {
            CreateAccounts();
        }
        private void CreateAccounts()
        {
            accounts.Add(new StoreAccount
            {
                UserName = "Alfred",
                Password = "program",
                StorePosition = "owner",
                AccountId = "05-09-04"
            });

            accounts.Add(new StoreAccount
            {
                UserName = "admin",
                Password = "admin",
                StorePosition = "cashier",
                AccountId = "11-22-33"
            });
        }
        public bool ValidateUserAccount(string username, string password)
        {
            foreach (var account in accounts)
            {
                if (account.UserName == username && account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
