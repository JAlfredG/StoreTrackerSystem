using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STSCommon;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class STSAccountController : ControllerBase
    {
        static STSBusinessDataLogic.AccountBL accountService = new STSBusinessDataLogic.AccountBL();

        [HttpGet]
        public IEnumerable<StoreAccount> GetUsers()
        {
            var accounts = accountService.GetStoreAccounts();

            return accounts;
        }
    }
}
