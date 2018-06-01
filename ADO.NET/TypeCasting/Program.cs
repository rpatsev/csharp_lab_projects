using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = "5";
            int b = (int)a;
            int? c = a as int?;
        }
    }
}
