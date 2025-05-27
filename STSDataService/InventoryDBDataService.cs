using Microsoft.Data.SqlClient;
using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSDataService
{
    public class InventoryDBDataService : InventoryISTSDataSercvice
    {
        //connectionString
        static string connectionString = "Data Source =LAPTOP-P710F399\\SQLEXPRESS; Initial Catalog = StoreTrackerSystem; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public InventoryDBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<ItemInventory> GetInventory()
        {
            var selectStatement = "SELECT * FROM ItemInventory";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var stsInventory = new List<ItemInventory>();

            while (reader.Read())
            {
                //deserialize

                ItemInventory itemInventory = new ItemInventory();
                itemInventory.ItemName = reader["ItemName"].ToString();
                itemInventory.ItemQuantity = int.Parse(reader["ItemQuantity"].ToString());
                itemInventory.ItemPrice = Double.Parse(reader["ItemPrice"].ToString());

                stsInventory.Add(itemInventory);

            }

            sqlConnection.Close();

            return stsInventory;
        }
        public void AddItem(ItemInventory item)
        {
            throw new NotImplementedException();
        }
        public void RemoveItem(ItemInventory item)
        {
            throw new NotImplementedException();
        }
        public void UpdateItemQuantity(ItemInventory item)
        {
            throw new NotImplementedException();
        }
        public void UpdateItemPrice(ItemInventory item)
        {
            throw new NotImplementedException();
        }
    }
}
