using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{

    //TO BE FIXED
    public class STSInventoryData
    {
        ISTSInventoryDataService STSInventoryDataService;
        public STSInventoryData()
        {
            STSInventoryDataService = new InventoryDataTextFile();
        }

        public List<ItemInventory> GetInventory()
        {
            return STSInventoryDataService.GetItemInventory();
        }

        public void CreateItem(ItemInventory inventory)
        {
            STSInventoryDataService.CreateItem(inventory);
        }

        public void UpdateItemQuantity(ItemInventory inventory)
        {
            STSInventoryDataService.UpdateItemQuantity(inventory);
        }

        public void UpdateItemPrice(ItemInventory inventory)
        {
            STSInventoryDataService.UpdateItemPrice(inventory);
        }

        public void RemoveItem(ItemInventory inventory)
        {
            STSInventoryDataService.RemoveItem(inventory);
        }
    }
}
