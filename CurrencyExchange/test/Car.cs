using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Car
    {
        public const int NumberOfWheels = 4 ;
        public static readonly int NumberOfDoors;

        static Car()
        {
            NumberOfDoors = 4;
        }

        public void Start()
        {
            Console.WriteLine("Car goes");
        }

        int a = 0;
        object b = a;


        object[] array = new object[3] { a, "ppp", 'q' };

        dynamic d = new Car();

        d = 5;
    }
}
