using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{
    public class AccountDataTextFile : AccountISTSDataService
    {
        string filePath = "accounts.txt";
        List<StoreAccount> accounts = new List<StoreAccount>();

        public AccountDataTextFile()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var part = line.Split('|');

                accounts.Add(new StoreAccount
                {
                    UserName = part[0],
                    Password = part[1],
                    StorePosition = part[2],
                    AccountId = part[3]
                });
            }
        }

        public List<StoreAccount> GetAccounts()
        {
            return accounts;
        }
    }
}
