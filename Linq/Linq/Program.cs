using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jim" , "Harry" , "Julia", "Sam" };

            IEnumerable<string> filteredNames = names.Where(name => name.Contains("a"));

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            

            filteredNames = Enumerable.Where(names, name => name.Contains("a"));

            IEnumerable<int> countLetters = names.Select(name => name.Length);

            foreach(int count in countLetters)
            {
                Console.WriteLine(count);
            }

            IEnumerable<string> orderedNames = names.OrderByDescending(name => name.Length);

            foreach (string name in orderedNames)
            {
                Console.WriteLine(name);
            }

            IEnumerable<int> filteredAndOrderedNames = names
                .Where(name => name.Contains("a"))
                .Select(name => name.Length)
                .OrderByDescending(count => count);

            foreach(int count in filteredAndOrderedNames)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("----------Take 3------------");
            int[] numbers = { 4,6,7,34,652,64 };
            IEnumerable<int> firstThree = numbers.Take(3);
            foreach (int number in firstThree)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("----------Skip-------------");
            IEnumerable<int> skipThree = numbers.Skip(3);
            foreach (int number in skipThree)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("----------Reverse-------------");
            IEnumerable<int> reversedNumber = numbers.Reverse();
            foreach (int number in reversedNumber)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("----------First, Last, ElementAt-------------");
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.First(number => number > 100));
            Console.WriteLine(numbers.ElementAt(5));

            Console.WriteLine("----------Count, Min, Max, Average-------------");
            Console.WriteLine(numbers.Count(number => number % 2 == 0));

            Console.WriteLine(numbers.Min());

            Console.WriteLine("--------------------Contains-------------------");
            Console.WriteLine(numbers.Contains(45));

            Console.WriteLine("-----------------------Any------------------------");
            Console.WriteLine(numbers.Any(number => number < 0));

            Console.WriteLine("-----------------------All------------------------");
            Console.WriteLine(numbers.All(number => number > 0));

            Console.WriteLine("-----------------------Concat---------------------");
            int[] numbers2 = { 4, 34, 7, 54, 6526, 34 };
            IEnumerable < int > twoArrays = numbers.Concat(numbers2);

            foreach(int number in twoArrays)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------Union---------------------");
            IEnumerable<int> unionedArrays = numbers.Union(numbers2);

            foreach (int number in unionedArrays)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("-----------------------Subquery---------------------");
            IEnumerable<string> namesLongerThanAverage = names.Where(name => name.Length > names.Average(n => n.Length));

            foreach(string name in namesLongerThanAverage)
            {
                Console.WriteLine(name);
            }
        }
    }
}
