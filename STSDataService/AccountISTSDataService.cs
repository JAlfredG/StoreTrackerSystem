using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{
    public interface AccountISTSDataService
    {
        public List<StoreAccount> GetAccounts();

    }
}
