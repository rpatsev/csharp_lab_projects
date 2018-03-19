using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        private static Random r = new Random();
        public static void Main(string[] args)
        {
            var listOfIntegers = Enumerable
                .Range(0, 20)
                .Select(_=>r.Next(0,30))
                .Where(IsDividedBySix)
                .Union(new List<int> { 10,15,20,40})
                .Skip(2)
                .Take(3)
                .Reverse()
                .OrderBy(_ => _)
                .GroupBy(_ => _ % 2)
                .Select(_ => Tuple.Create(_.Key, _.Count()))
                .ToList();
        }

        private static bool IsDividedBySix(int number)
            => number % 2 == 0 || number % 3 == 0;
        
    }
}
