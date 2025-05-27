using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{

    //TO BE FIXED
    public class InventorySTSData
    {
        InventoryISTSDataSercvice STSInventoryDataService;
        public InventorySTSData()
        {
            //STSInventoryDataService = new InventoryDataInMemory();
            STSInventoryDataService = new InventoryDBDataService();
        }

        public List<ItemInventory> GetInventory()
        {
            return STSInventoryDataService.GetInventory();
        }

        public void AddItem(ItemInventory inventory)
        {
            STSInventoryDataService.AddItem(inventory);
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
