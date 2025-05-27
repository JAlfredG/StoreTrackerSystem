using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace STSDataService
{
    public class AccountDataJsonFile
        
        : AccountISTSDataService
    {
        static List<StoreAccount> accounts = new List<StoreAccount>();
        static string jsonFilePath = "accounts.json";

        public AccountDataJsonFile()
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
