using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertRegion(5, "Central");
            //var customers = GetCustomers("London");
            int id = InsertRegion("Central");
        }

        private static void InsertRegion(int id, string name)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string query = "INSERT INTO [Northwind].[dbo].[Region] VALUES (@id, @name)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);

                int affectedRows = command.ExecuteNonQuery();
            }
        }

        private static List<object> GetCustomers(string city)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string query = "SELECT * FROM[dbo].[Customers] WHERE City = 'London';";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var customers = new List<object>();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@city", city);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string customerId = reader["CustomerId"] == DBNull.Value ? null : (string)reader["CustomerId"];
                            string companyName = reader["CompanyName"].ToString();
                            string contactName = reader["ContactName"].ToString();
                            string contactTitle = reader["ContactTitle"].ToString();
                            string address = reader["Address"].ToString();
                            string cityFromReader = reader["City"].ToString();
                            string region = reader["Region"].ToString();
                            string country = reader["Country"].ToString();
                            string code = reader["PostalCode"].ToString();
                            string phone = reader["Phone"].ToString();
                            string fax = reader["Fax"].ToString();


                            customers.Add(new
                            {
                                CustomerId = customerId,
                                CompanyName = companyName,
                                ContactName = contactName,
                                ContactTitle = contactTitle,
                                Address = address,
                                CityFromReader = cityFromReader,
                                Region = region,
                                PostalCode = code,
                                Country = country,
                                Code = code,
                                Phone = phone,
                                Fax = fax
                            });

                        }
                    }
                }

                return customers;
            }
        }

        private static int InsertRegion(string name)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string query = @"DECLARE @id INT;
                            SELECT @id = MAX(RegionID) + 1 FROM[dbo].[Region]
                            INSERT INTO[dbo].[Region] VALUES(@id, @name)
                            SELECT @id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                int id = (int)command.ExecuteScalar();

                return id;
            }
        }
    }
}
