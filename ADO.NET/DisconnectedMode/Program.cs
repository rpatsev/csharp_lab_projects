using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedMode
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string query = "SELECT * FROM [Region]";

            string tableName = "Region";

            using (var connection = new SqlConnection(connectionString))
            {
                var adapter = new SqlDataAdapter(query, connection);
                var regions = new DataSet();
                adapter.Fill(regions, tableName);
                DataTable table = regions.Tables[tableName];

                int maxId = 0;

                foreach(DataRow row in table.Rows)
                {
                    int rowId = (int)row["RegionId"];
                    Console.WriteLine("{0} {1}", rowId, row["RegionDescription"]);
                    maxId = rowId > maxId ? rowId : maxId; 
                }

   
                DataRow newRow = table.NewRow();
                newRow["RegionId"] = maxId + 1;
                newRow["RegionDescription"] = "NewRegion1";

                table.Rows.Add(newRow);

                var builder = new SqlCommandBuilder(adapter);
                builder.GetInsertCommand();

                adapter.Update(table);

                newRow.Delete();
                adapter.Update(table);
            }
        }
    }
}
