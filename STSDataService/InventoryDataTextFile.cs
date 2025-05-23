using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{

    //TO BE FIXED

    public class InventoryDataTextFile : ISTSInventoryDataService
    {
        string filePath = "inventory.txt";
        List<ItemInventory> itemInventory = new List<ItemInventory>();

        public InventoryDataTextFile()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var part = line.Split('|');

                itemInventory.Add(new ItemInventory
                {
                    ItemName = part[0],
                    ItemQuantity = Convert.ToInt16(part[1]),
                    ItemPrice = Convert.ToInt16(part[2])
                });
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[itemInventory.Count];

            for (int i = 0; i < itemInventory.Count; i++)
            {
                lines[i] = $"{itemInventory[i].ItemName}|{itemInventory[i].ItemQuantity}|{itemInventory[i].ItemPrice}";
            }

            File.WriteAllLines(filePath, lines);
        }

        public int FindIndex(ItemInventory item)
        {
            for (int i = 0; i < itemInventory.Count; i++)
            {
                if (itemInventory[i].ItemName == item.ItemName)
                {
                    return i;
                }
            }

            return -1;
        }

        public List<ItemInventory> GetItemInventory()
        {
            return itemInventory;
        }

        public void CreateItem(ItemInventory item)
        {
            var newLine = $"{item.ItemName}|{item.ItemQuantity} | {item.ItemPrice}";

            File.AppendAllText(filePath, newLine);
        }

        public void UpdateItemQuantity(ItemInventory item)
        {
            int index = FindIndex(item);

            itemInventory[index].ItemName = item.ItemName;

            WriteDataToFile();
        }

        public void UpdateItemPrice(ItemInventory item)
        {
            int index = FindIndex(item);

            itemInventory[index].ItemName = item.ItemName;

            WriteDataToFile();
        }

        public void RemoveItem(ItemInventory item)
        {
            int index = -1;
            for (int i = 0; i < itemInventory.Count; i++)
            {
                if (itemInventory[i].ItemName == item.ItemName)
                {
                    index = i;
                }
            }

            itemInventory.RemoveAt(index);

            WriteDataToFile();
        }
    }
}
