using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSDataService
{

    //TO BE FIXED

    public interface InventoryISTSDataSercvice
    {
        public List<ItemInventory> GetInventory();
        public void AddItem(ItemInventory item);
        public void RemoveItem(ItemInventory item);
        public void UpdateItemQuantity(ItemInventory item);
        public void UpdateItemPrice(ItemInventory item);
    }
}
