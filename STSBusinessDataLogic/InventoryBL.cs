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

        public static List<ItemInventory> GetInventory()
        {
            return inventoryData.GetInventory();
        }

        public static bool CheckInventory()
        {
            return inventoryData.GetInventory().Count > 0;
        }

        public static bool CheckItemQuantity(int itemQuantity)
        {
            return itemQuantity > 0;
        }

        public static bool CheckItemInInventory(string itemInput)
        {
            var items = inventoryData.GetInventory();

            foreach (var item in items)
            {
                if (item.ItemName.Trim().Equals(itemInput, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
        public static void AddItem(string itemName, double itemPrice, int itemQuantity)
        {
            var item = new ItemInventory
            {
                ItemName = itemName,
                ItemPrice = itemPrice,
                ItemQuantity = itemQuantity
            };

            inventoryData.AddItem(item);
        }

        public static void RemoveItem(string itemName)
        {
            var item = new ItemInventory
            {
                ItemName = itemName
            };
            CheckItemInInventory(itemName);
            if (CheckItemInInventory(itemName))
            {
                inventoryData.RemoveItem(item);
            }

        }

        public static void UpdateQuantity(string itemName, int itemQuantity)
        {
            var items = inventoryData.GetInventory();

            foreach (var item in items)
            {
                if (item.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    item.ItemQuantity = itemQuantity;
                    inventoryData.UpdateItemQuantity(item);
                }
            }
        }

        public static void UpdatePrice(string itemName, double itemPrice)
        {
            var items = inventoryData.GetInventory();

            foreach (var item in items)
            {
                if (item.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    item.ItemPrice = itemPrice;
                    inventoryData.UpdateItemPrice(item);
                }
            }
        }
    }
}
