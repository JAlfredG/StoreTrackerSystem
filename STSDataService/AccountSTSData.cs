using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{
    public class AccountSTSData
    {
        AccountISTSDataService STSAccountDataService;
        public AccountSTSData()
        {
            //STSAccountDataService = new AccountDataInMemory();
            //STSAccountDataService = new AccountDataTextFile();
            //STSAccountDataService = new AccountDataJsonFile();
            STSAccountDataService = new AccountDBDataService();
        }
        public List<StoreAccount> GetAllAccounts()
        {
            return STSAccountDataService.GetAccounts();
        }


    }
}
