using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace STSDataService
{
    public class AccountDataJasonFile : ISTSAccountDataService
    {
        static List<StoreAccount> accounts = new List<StoreAccount>();
        static string jsonFilePath = "accounts.json";

        public AccountDataJasonFile()
        {
            GetDataFromJsonFile();
        }

        private void GetDataFromJsonFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);

            accounts = JsonSerializer.Deserialize<List<StoreAccount>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        public List<StoreAccount> GetAccounts()
        {
            return accounts;
        }
    }
}
