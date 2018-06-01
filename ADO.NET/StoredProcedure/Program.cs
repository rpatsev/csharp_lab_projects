using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertRegion("srjghwligkjkerlgm");
            GetCustomerWithOrders("AROUT");
        }

        private static int InsertRegion(string name)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string storedProcedure = @"InsertRegion";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", name);

                int id = (int)command.ExecuteScalar();

                return id;
            }
        }

        private static void GetCustomerWithOrders(string customerId)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                                        Database=Northwind;
                                        Trusted_Connection=True;";

            string storedProcedure = @"GetCustomerWithOrders";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = new SqlCommand(storedProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customerId", customerId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        
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


                            var customer = new
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
                                Fax = fax,
                                Orders = new List<object>()
                            };

                        reader.NextResult();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                customer.Orders.Add
                                (
                                    new
                                    {
                                        OrderId = reader["OrderId"],
                                        ShipPostalCode = reader["ShipPostalCode"]
                                    }
                                );
                            }
                        }

                    
                    }

                }
            }
            //return customer;
        }
    }
}
