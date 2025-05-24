using STSCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace STSDataService
{
    public class DBDataService : ISTSAccountDataService
    {
        //connectionString
        static string connectionString = "Data Source =LAPTOP-P710F399\\SQLEXPRESS; Initial Catalog = StoreTrackerSystem; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<StoreAccount> GetAccounts()
        {
            var selectStatement = "SELECT * FROM AccountsDetails";

            SqlCommand selectCommand =new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var stsAccounts = new List<StoreAccount>();

            while (reader.Read())
            {
                //deserialize

                StoreAccount storeAccount = new StoreAccount();
                storeAccount.UserName = reader["Username"].ToString();
                storeAccount.Password = reader["Password"].ToString();
                storeAccount.StorePosition = reader["StorePosition"].ToString();
                storeAccount.AccountId = reader["AccountId"].ToString();

                stsAccounts.Add(storeAccount);


            }

            sqlConnection.Close();

            return stsAccounts;
        }
    }
}
