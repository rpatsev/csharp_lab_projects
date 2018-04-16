using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello world";
            hello = hello.Replace(" ", ", ");
            Console.WriteLine(hello);

            String.Intern(hello);
            String.IsInterned(hello);

            string s1 = "hello";
            string s2 = "hello";

            Console.WriteLine(Object.ReferenceEquals(s1, s2));

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                sb.Append(i).Append(" ");
                sb.Append(i);
                sb.AppendLine();
                sb.AppendFormat("i is {0}",i);
            }

            var result = sb.ToString();

            Console.WriteLine(result);

            s1.Equals(s2, StringComparison.Ordinal);
            s1.Equals(s2, StringComparison.CurrentCulture);
            s1.Equals(s2, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("hello \n \r world");
            Console.WriteLine(String.Format(@"hello {0} world", Environment.NewLine));

            string input = "45 s5464ome input 1 with digits 23 23421";

            //Regex regex = new Regex(@"(^\d)|(\s\d+\s)|(\d+$)");
            //Regex regex = new Regex(@"^[a-zA-Z]+");
            Regex regex = new Regex(@"^(.+)$");

            bool isMatch = regex.IsMatch(input);
            
            MatchCollection matches = regex.Matches(input);
            GroupCollection groups = matches[0].Groups;
        }
    }
}
