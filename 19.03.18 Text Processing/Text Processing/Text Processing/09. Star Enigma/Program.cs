using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<string>>();
            dict["Attacked planets"] = new List<string>();
            dict["Destroyed planets"] = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                bool planet = false;
                bool planetPopulation = false;
                bool soldersCount = false;

                string aOrD = string.Empty;
                string pl = string.Empty;

                var matches = Regex.Matches(input, @"[starSTAR]");
                int key = matches.Count;

                string decriptedMassage = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    char newChar = (char)(input[j] - key);
                    decriptedMassage += newChar;
                }
                if (Regex.IsMatch(decriptedMassage, @"(?<=@)[A-Za-z]+"))
                {
                    var match = Regex.Match(decriptedMassage, @"(?<=@)[A-Za-z]+");

                    pl = match.Value;

                    planet = true;
                }

                if(Regex.IsMatch(decriptedMassage, @"(?<=->)[\d]+"))
                {
                    soldersCount = true;
                }

                if (Regex.IsMatch(decriptedMassage, @"(?<=:)[\d]+"))
                {
                    planetPopulation = true;
                }
                
                if (Regex.IsMatch(decriptedMassage, @"(?<=!)[AD](?=!)"))
                {
                    var match = Regex.Match(decriptedMassage, @"(?<=!)[AD](?=!)");
                    aOrD = match.Value;
                    if (aOrD == "A" && planet && soldersCount && planetPopulation)
                    {
                        dict["Attacked planets"].Add(pl);
                    }
                    else if (aOrD == "D" && planet && soldersCount && planetPopulation)
                    {
                        dict["Destroyed planets"].Add(pl);
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var value in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {value}");
                }
            }
        }
    }
}
