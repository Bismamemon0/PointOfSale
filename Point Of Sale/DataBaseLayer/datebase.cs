using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Point_Of_Sale.DataBaseLayer
{
   public class datebase
    {
        private static SqlConnection conn;
        public static SqlConnection connOpen()
        {
            try
            {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-4UCGRF2\MSSQLSERVER01;Initial Catalog=InventoryManagementSystem;Integrated Security=True");
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void InsertData (string query)
        {
            try
            {
            SqlCommand cmd = new SqlCommand(query , connOpen());
            cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception )
            {
            }
        }

        public static void DeleteData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connOpen());
                cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception)
            {
            }
        }

        public static DataTable Retrivedata (string query)
        {
            try
            {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, connOpen());
            sda.Fill(dt);
            return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void NewPurchase(int supplierID,int purchaseID, int productID, string productName, int categoryID , string categoryName , float purchaseQuantity , float purchaseUnitPrice,float saleUnitPrice , string quality )
        {
            SqlCommand cmd = new SqlCommand("NewPurchase", connOpen());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            cmd.Parameters.AddWithValue("@purchaseQuantity", purchaseQuantity);
            cmd.Parameters.AddWithValue("@purchaseUnitPrice", purchaseUnitPrice);
            cmd.Parameters.AddWithValue("@saleUnitPrice", saleUnitPrice);
            cmd.Parameters.AddWithValue("@Quanlity", quality);

            cmd.ExecuteNonQuery();
        }

    }
}


