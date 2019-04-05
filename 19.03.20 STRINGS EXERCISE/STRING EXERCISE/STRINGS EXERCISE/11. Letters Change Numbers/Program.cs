using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal finalResult = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                string str = tokens[i];

                var match = Regex.Match(str, @"[\d]+");
                int readNumber = int.Parse(match.ToString());
                decimal result = readNumber;

                char firstChar = str[0];
                char lastChar = str[str.Length - 1];

                int numberInAlphabet = 0;

                if (char.IsUpper(firstChar))
                {
                    numberInAlphabet = (int)firstChar - 64;
                    result /= (decimal)numberInAlphabet;
                }
                else if (char.IsLower(firstChar))
                {
                    numberInAlphabet = (int)firstChar - 96;
                    result *= numberInAlphabet;
                }

                if (char.IsUpper(lastChar))
                {
                    numberInAlphabet = (int)lastChar - 64;
                    result -= numberInAlphabet;
                }
                else if (char.IsLower(lastChar))
                {
                    numberInAlphabet = (int)lastChar - 96                                                                         ;
                    result += numberInAlphabet;
                }

                finalResult += result;
            }

            Console.WriteLine($"{finalResult:f2}");
        }
    }
}
