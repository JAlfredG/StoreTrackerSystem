using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSBusinessDataLogic
{
    public class InventoryManagementBL
    {
        public static int itemQuantity;
        public static Dictionary<string, int> inventory = new Dictionary<string, int>();

        public static string UpdateInventory(Actions userAction, string item)
        {
            if (userAction == Actions.AddItem)
            {
                inventory.Add(item, itemQuantity);
            }
            else if (userAction == Actions.RemoveItem)
            {
                inventory.Remove(item);
            }
            else if (userAction == Actions.UpdateQuantity)
            {
                inventory[item] = itemQuantity;
            }
            return item;
        }
        public static bool CheckInventory()
        {
            return inventory.Count > 0;
        }

        public static bool CheckItemQuantity()
        {
            return itemQuantity > 0;
        }

        public static bool CheckItemInInventory(string item)
        {
            if (inventory.ContainsKey(item))
            {
                return true;
            }
            return false;
        }
    }
}
