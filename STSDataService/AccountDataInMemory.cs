using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{
    public class AccountDataInMemory : ISTSAccountDataService
    {
        List<StoreAccount> accounts = new List<StoreAccount>();
        public AccountDataInMemory()
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

            accounts.Add(new StoreAccount
            {
                UserName = "light",
                Password = "codm",
                StorePosition = "cashier",
                AccountId = "55-99-44"
            });
        }
        public List<StoreAccount> GetAccounts()
        {
            return accounts;
        }
    }
}
