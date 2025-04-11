using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STSCommon;

namespace STSBusinessDataLogic
{
    public class InventoryBL
    {
        public static int itemQuantity;
        public static double itemPrice;
        public static List<ItemInventory> items = new List<ItemInventory>();

        public static string UpdateInventory(Actions userAction, string item)
        {
            if (userAction == Actions.AddItem)
            {
                AddItem(item, itemQuantity, itemPrice);
            }
            else if (userAction == Actions.RemoveItem)
            {
                RemoveItem(item);
                
            }
            else if (userAction == Actions.UpdateQuantity)
            {
                UpdateQuantity(item);
            }
            else if(userAction == Actions.UpdatePrice)
            {
                UpdatePrice(item);
            }
            return item;
        }

        static void AddItem(string itemname, int itemquantity, double itemprice)
        {
            items.Add(new ItemInventory
            {
                ItemName = itemname,
                ItemQuantity = itemquantity,
                ItemPrice = itemprice
            });
        }

        static void RemoveItem(string itemname)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(itemname, StringComparison.OrdinalIgnoreCase))
                {
                    items.RemoveAt(i);
                }
            }
        }

        static void UpdateQuantity(string itemname)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(itemname, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].ItemQuantity = itemQuantity;
                }
            }
        }

        static void UpdatePrice(string itemname)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemName.Equals(itemname, StringComparison.OrdinalIgnoreCase))
                {
                    items[i].ItemPrice = itemPrice;
                }
            }
        }

        public static  bool CheckInventory()
        {
            return items.Count > 0;
        }

        public static bool CheckItemQuantity()
        {
            return itemQuantity > 0;
        }

        public static bool CheckItemInInventory(string itemInput)
        {
            foreach(var item in items)
            {
                if(item.ItemName.Equals(itemInput, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
