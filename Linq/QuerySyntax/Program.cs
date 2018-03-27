using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jim", "Harry", "Julia", "Sam" };

            Console.WriteLine("---Where----");
            IEnumerable<string> filteredNames = from name in names where name.Contains("a") select name; 

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---Where----");

            IEnumerable<int> countLetters = from name in names select name.Length;

            foreach (int count in countLetters)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("---Order By----");

            IEnumerable<string> orderedNames = from name in names orderby name select name;
            orderedNames = from name in names where name.Length > 3 orderby name descending select name;

            foreach (string name in orderedNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---Into----");

            IEnumerable<int> counts = from name in names
                            where name.Length > 3
                            select name into name1
                            where name1.Contains("a")
                            select name1 into name2
                            select name2.Length;

            foreach (int count in counts)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("---Let----");

            filteredNames = from name in names
                            let min = names.Min(n => n.Length)
                            where name.Length > min
                            select name;

            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---Select ClaSS----");

            IEnumerable<StringWithLength> strings = from name in names
                            let min = names.Min(n => n.Length)
                            where name.Length > min
                            select new StringWithLength
                            {
                                Value = name,
                                Length = name.Length
                            };

            foreach (StringWithLength stringWithLength in strings)
            {
                Console.WriteLine(stringWithLength);
            }

            Console.WriteLine("---Select Anomymous objects----");

            var anonymousObjects = from name in names
                                   let min = names.Min(n => n.Length)
                                   where name.Length > min
                                   select new                                    {
                                       Value = name,
                                       Length = name.Length,
                                       Min = min
                                   };

            foreach (var anonymousObject in anonymousObjects)
            {
                Console.WriteLine(anonymousObject);
            }

            countLetters = from count in 
                            (
                            from name in names
                            select name.Length
                            )
                            where count > 2
                            select count; 

            foreach (int count in countLetters)
            {
                Console.WriteLine(count);
            }

        }
    }
}
