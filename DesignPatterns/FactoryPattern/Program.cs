using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UMLExample();
            using (IDbConnection connection = ConnectionFactory.CreateConnection(ConnectionType.SqlServer))
            {
                connection.ConnectionString = "";
                connection.Open();
            }

        }

        private static void UMLExample()
        {
            var creator = new ConcreteCreator();
            Product product = creator.FactoryMethod(0);
            Console.WriteLine(product.GetType());
            product = creator.FactoryMethod(1);
            Console.WriteLine(product.GetType());
        }
    }
}
