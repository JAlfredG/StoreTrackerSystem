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
            var insertStatement = "INSERT INTO ItemInventory VALUES (@ItemName, @ItemQuantity, @ItemPrice)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@ItemName", item.ItemName);
            insertCommand.Parameters.AddWithValue("@ItemQuantity", item.ItemQuantity);
            insertCommand.Parameters.AddWithValue("@ItemPrice", item.ItemPrice);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void RemoveItem(ItemInventory item)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM ItemInventory WHERE ItemName = @ItemName";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@ItemName", item.ItemName);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void UpdateItemQuantity(ItemInventory item)
        {
            sqlConnection.Open();

            var updateStatement = $"UPDATE ItemInventory SET ItemQuantity = @ItemQuantity WHERE ItemName = @ItemName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@ItemQuantity", item.ItemQuantity);
            updateCommand.Parameters.AddWithValue("@ItemName", item.ItemName);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void UpdateItemPrice(ItemInventory item)
        {
            sqlConnection.Open();

            var updateStatement = $"UPDATE ItemInventory SET ItemPrice = @ItemPrice WHERE ItemName = @ItemName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@ItemPrice", item.ItemPrice);
            updateCommand.Parameters.AddWithValue("@ItemName", item.ItemName);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
