using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string regexName = @"@(?<name>[A-Z]?[a-z]+)\|";
                var matchName = Regex.Match(input, regexName);
                string name = matchName.Groups["name"].Value;

                string regexAge = @"\#(?<age>[\d]+)\*";
                var matchAge = Regex.Match(input, regexAge);
                string age = matchAge.Groups["age"].Value;

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
