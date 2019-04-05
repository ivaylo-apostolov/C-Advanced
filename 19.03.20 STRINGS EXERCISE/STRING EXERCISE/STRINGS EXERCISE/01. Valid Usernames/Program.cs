using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine();

            string regex = @"\b(?<![\W|_])[\w-]{3,16}\b";

            MatchCollection matchs = Regex.Matches(arr, regex);

            foreach (Match match in matchs)
            {
                Console.WriteLine(match);
            }
            
        }
    }
}
