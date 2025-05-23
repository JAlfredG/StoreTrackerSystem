using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{

    //TO BE FIXED

    public interface ISTSInventoryDataService
    {
        public List<ItemInventory> GetItemInventory();
        public void CreateItem(ItemInventory item);
        public void UpdateItemQuantity(ItemInventory item);
        public void UpdateItemPrice(ItemInventory item);
        public void RemoveItem(ItemInventory item);

    }
}
