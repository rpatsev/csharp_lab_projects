using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLEDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Provider=SQLOLEDB;
                                        Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=Northwind;
                                        Integrated Security=SSPI";

            string query = "SELECT * FROM [Region]";

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                var command = new OleDbCommand(query, connection);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1}", reader["RegionId"], reader["RegionDescription"]);
                    }
                }
            }
        }
    }
}
