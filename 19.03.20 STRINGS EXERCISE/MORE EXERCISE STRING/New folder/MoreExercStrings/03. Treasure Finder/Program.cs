using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string massageToDecript = string.Empty;
            string decriptedMassage = string.Empty;

            while ((massageToDecript = Console.ReadLine()) != "find")
            {
                decriptedMassage = string.Empty;
                for (int i = 0, j = i % tokens.Length; i < massageToDecript.Length; i++)
                {
                    j = i % tokens.Length;
                    int decreaseByNumber = tokens[j];

                    char character = massageToDecript[i];
                    character -= (char)decreaseByNumber;

                    decriptedMassage += character;
                    j = (i + 1) % tokens.Length;
                }

                string regex = @"\&(?<type>\w+)\&[\w\d]*\<(?<coordinates>[\w\d]+)\>";

                var matches = Regex.Matches(decriptedMassage, regex);

                foreach (Match match in matches)
                {
                    string type = match.Groups["type"].Value;
                    string coordinates = match.Groups["coordinates"].Value;
                    Console.WriteLine($"Found {type} at {coordinates}");
                }
            }

            Console.WriteLine();
        }
    }
}
