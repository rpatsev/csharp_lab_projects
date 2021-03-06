﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join("," ,Enumerable.Range(10, 41)));
            Console.WriteLine(string.Join(",", Enumerable.Range(10, 41).Where(number => number % 3 == 0)));
            Console.WriteLine(string.Join(",", Enumerable.Repeat("Linq", 10)));
            Console.WriteLine(string.Join(",", "aaa;bbb;ccc;dap".Split(';').Where(word=>word.Contains("a"))));
            Console.WriteLine(string.Join(",", "aaa;bbb;ccc;dap".Split(';').Where(word => word.Contains("a")).Select(word => word.Count(w => w == 'a'))));
            Console.WriteLine("aaa;xabbx;aaa;ccc;dap".Contains("dap"));
            Console.WriteLine("aaa;xabbx;aaa;ccc;dap".Split(';').OrderByDescending(word=>word.Length).First());
            Console.WriteLine("aaa;xabbx;aaa;ccc;dap".Split(';').First(word => word.Length == "aaa;xabbx;aaa;ccc;dap".Split(';').Max(word1 => word1.Length)));
            Console.WriteLine("aaa;xabbx;aaa;ccc;dap".Split(';').Average(word => word.Length));
            Console.WriteLine(string.Join("","aaa;xabbx;aaa;ccc;dap;zh".Split(';').OrderBy(word => word.Length).First().Reverse()));
            Console.WriteLine("baaa;aaa;xabbx;abb;aaaaa;ccc;dap;zh".Split(';').FirstOrDefault(word => word.StartsWith("aa")) == null ? false :
                "baaa;aaa;xabbx;abb;aaaaa;ccc;dap;zh".Split(';').First(word => word.StartsWith("aa")).All(character => character == 'a'));
            Console.WriteLine(
                "baaa;aabb;xabbx;abb;aaaaa;ccc;dap;zh".Split(';').Except
                ("baaa;aabb;xabbx;abb;aaaaa;ccc;dap;zh".Split(';').Where(word=>word.EndsWith("bb")).Skip(2)).Last());



            Console.WriteLine("======================LEVEL 2===========================");

            var data = new List<object>() {
                        "Hello",
                        new Book() { Author = "Terry Pratchett", Name = "Guards! Guards!", Pages = 810 },
                        new List<int>() {4, 6, 8, 2},
                        new string[] {"Hello inside array"},
                        new Film() { Author = "Martin Scorsese", Name= "The Departed", Actors = new List<Actor>() {
                            new Actor() { Name = "Jack Nickolson", Birthdate = new DateTime(1937, 4, 22)},
                            new Actor() { Name = "Leonardo DiCaprio", Birthdate = new DateTime(1974, 11, 11)},
                            new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)}
                        }},
                        new Film() { Author = "Gus Van Sant", Name = "Good Will Hunting", Actors = new List<Actor>() {
                            new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)},
                            new Actor() { Name = "Robin Williams", Birthdate = new DateTime(1951, 8, 11)},
                        }},
                        new Book() { Author = "Stephen King", Name="Finders Keepers", Pages = 200},
                        "Leonardo DiCaprio"
                    };

            Console.WriteLine("1) " + string.Join(",",data.Except(data.OfType<ArtObject>()).Select(_ => _).ToArray()));
            Console.WriteLine("2) " + string.Join(",", data.OfType<Film>().SelectMany(film => film.Actors).Select(actor => actor.Name).Distinct().ToArray()));
            Console.WriteLine("3) " + data.OfType<Film>().SelectMany(film => film.Actors).Where(actor => actor.Birthdate.Month == 8).Select(actor=>actor).Count());
            Console.WriteLine("4) " + string.Join(",", data.OfType<Film>().SelectMany(film => film.Actors).OrderBy(actor => actor.Birthdate.Year).Take(2).Select(actor => actor.Name).ToArray()));
            Console.WriteLine("5) " + string.Join(",", data.OfType<Book>().GroupBy(_ => ((Book)_).Author).Select(_=> new { AuthorName = _.Key, CountOfBooks = _.Count() }).ToList()));

            Console.WriteLine("10) " + data.OfType<Book>().Select(_=>_.Pages).Sum());
            //Console.WriteLine("12) " + string.Join(",", data.OfType<Actor>().Select(_ => (_ as Film).Actors.Where(_ => _.Name == "Matt Damon")).ToList());
        }
    }
}

class Actor
        {
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
        }

        abstract class ArtObject
        {

            public string Author { get; set; }
            public string Name { get; set; }
            public int Year { get; set; }
        }
        class Film : ArtObject
        {

            public int Length { get; set; }
            public IEnumerable<Actor> Actors { get; set; }
        }
        class Book : ArtObject
        {

            public int Pages { get; set; }
        }



