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
        ISTSAccountDataService STSAccountDataService;
        public STSAccountData()
        {
            //STSAccountDataService = new AccountDataInMemory();
            //STSAccountDataService = new AccountDataTextFile();
            //STSAccountDataService = new AccountDataJasonFile();
            STSAccountDataService = new DBDataService();
        }
        public List<StoreAccount> GetAllAccounts()
        {
            return STSAccountDataService.GetAccounts();
        }


    }
}
