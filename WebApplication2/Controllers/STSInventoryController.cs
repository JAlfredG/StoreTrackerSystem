using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STSBusinessDataLogic;
using STSCommon;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class STSInventoryController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<ItemInventory> GetInventories()
        {
            var items = InventoryBL.GetInventory();

            return items;
        }

        [HttpPost("AddItem")]
        public bool AddItem(ItemInventory request)
        {
            return InventoryBL.AddItem(request.ItemName, request.ItemQuantity, (int)request.ItemPrice);

        }

        [HttpDelete("DeleteItem")]
        public bool RemoveItem(string itemName)
        {
            return InventoryBL.RemoveItem(itemName);

        }

        [HttpPatch("UpdateQuantity")]
        public bool UpdateQuantity(string itemName, int itemQuantity)
        {
            var result = InventoryBL.UpdateQuantity(itemName, itemQuantity);
            return result;
        }

        [HttpPatch("UpdatePrice")]
        public bool UpdatePrice(string itemName, int itemPrice)
        {
            var result = InventoryBL.UpdatePrice(itemName, itemPrice);
            return result;
        }
    }
}
