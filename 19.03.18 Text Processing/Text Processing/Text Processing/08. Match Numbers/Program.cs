using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

            Console.WriteLine();
        }
    }
}
