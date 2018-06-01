using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Driver={SQL Server};
                                        Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connections=yes";

            string query = "SELECT * FROM [Region]";

            using (var connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                var command = new OdbcCommand(query, connection);

                using (OdbcDataReader reader = command.ExecuteReader())
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
