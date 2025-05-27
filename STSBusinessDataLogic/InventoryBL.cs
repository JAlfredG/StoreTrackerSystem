using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;
using STSDataService;

namespace STSBusinessDataLogic
{
    public class InventoryBL
    {
        static InventorySTSData inventoryData = new InventorySTSData();

        public static int itemQuantity;
        public static double itemPrice;

        public static string UpdateInventory(Actions userAction, string itemName)
        {
            var item = new ItemInventory
            {
                ItemName = itemName,
                ItemPrice = itemPrice,
                ItemQuantity = itemQuantity
            };

            if (userAction == Actions.AddItem)
            {
                inventoryData.AddItem(item);
            }
            else if (userAction == Actions.RemoveItem)
            {
                inventoryData.RemoveItem(item);

            }
            else if (userAction == Actions.UpdateQuantity)
            {
                inventoryData.UpdateItemQuantity(item);
            }
            else if (userAction == Actions.UpdatePrice)
            {
                inventoryData.UpdateItemPrice(item);
            }

            return itemName;
        }

        public static List<ItemInventory> GetInventory()
        {
            return inventoryData.GetInventory();
        }

        public static bool CheckInventory()
        {
            return inventoryData.GetInventory().Count > 0;
        }

        public static bool CheckItemQuantity()
        {
            return itemQuantity > 0;
        }

        public static bool CheckItemInInventory(string itemInput)
        {
            var items = inventoryData.GetInventory();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(itemInput, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
