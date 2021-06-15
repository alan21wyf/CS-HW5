using System;
using System.Data.SqlClient;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source = (local);Initial Catalog=Northwind;" + "Integrated Security=SSPI";
            CreateCommand("SELECT OrderID, CustomerID FROM dbo.Orders;", str);

        }

        public static void CreateCommand(string queryString, string myConnectString)
        {
            SqlConnection conn = new SqlConnection(myConnectString);
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();

        }
    }
}
