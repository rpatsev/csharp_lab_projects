using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ReadLine();
                ICountry country = Portal_.Work();
                Console.WriteLine("You are in {0}", country.Name);
                if (!Me.HasCurrency(country.Currency))
                {
                    Console.WriteLine("No such currency. Go to the currency exchange");
                }
            }
        }
    }
}
