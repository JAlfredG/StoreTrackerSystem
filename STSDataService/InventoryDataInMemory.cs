using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{
    public class InventoryDataInMemory : InventoryISTSDataSercvice
    {
        private static List<ItemInventory> items = new List<ItemInventory>();

        public InventoryDataInMemory()
        {
            CreateInventory();
        }

        private void CreateInventory()
        {
            items.Add(new ItemInventory
            {
                ItemName = "sugar",
                ItemPrice = 20,
                ItemQuantity = (int)55.0,
            });

            items.Add(new ItemInventory
            {
                ItemName = "cheese",
                ItemPrice = 30,
                ItemQuantity = (int)40.0,
            });

        }

        public void AddItem(ItemInventory item)
        {
            items.Add(item);
        }

        public List<ItemInventory> GetInventory()
        {
            return items;
        }

        public void RemoveItem(ItemInventory item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    items.RemoveAt(i);
                    break;
                }
            }
        }

        public void UpdateItemPrice(ItemInventory item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].ItemPrice = item.ItemPrice;
                    break;
                }
            }

        }

        public void UpdateItemQuantity(ItemInventory item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].ItemQuantity = item.ItemQuantity;
                    break;
                }
            }
        }
    }
}
