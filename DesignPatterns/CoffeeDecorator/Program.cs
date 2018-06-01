using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cup = new Cup();
            IIngredient beverage1 = new Water(cup);
            beverage1 = new Coffee(beverage1);
            beverage1 = new Milk(beverage1);

            Console.WriteLine(beverage1.Add());

            IIngredient beverage2 = new Water(cup);
            beverage2 = new Milk(beverage2);
            beverage2 = new Coffee(beverage2);
            beverage2 = new Cinnamon(beverage2);

            Console.WriteLine(beverage2.Add());

        }
    }
}
