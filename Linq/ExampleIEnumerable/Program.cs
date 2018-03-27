using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<char> query = "Not what you might expect";

            string vowels = "aeiou";

            for (int i = 0; i < vowels.Length; i++)
            {
                char currentChar = vowels[i];
                query = query.Where(c => c != currentChar);
            }

            foreach (char c in query)
            {
                Console.Write(c);
            }

            Console.ReadKey();
        }
    }
}
