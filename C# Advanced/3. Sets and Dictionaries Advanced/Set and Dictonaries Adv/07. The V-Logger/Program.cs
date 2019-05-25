using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            var input = string.Empty;

            while((input = Console.ReadLine()) != "Statistics")
            {
                var tokens = input
                    .Split()
                    .ToArray();

                var vlogger = tokens[0];
                var command = tokens[1];

                if (command == "joined")
                {
                    if (!dict.ContainsKey(vlogger))
                    {
                        dict[vlogger] = new Dictionary<string, SortedSet<string>>();
                        dict[vlogger]["followers"] = new SortedSet<string>();
                        dict[vlogger]["followed"] = new SortedSet<string>();
                    }
                }
                else if (command == "followed")
                {
                    var followedVlogger = tokens[2];

                    if (vlogger != followedVlogger && dict.ContainsKey(vlogger) && dict.ContainsKey(followedVlogger))
                    {
                        dict[vlogger]["followed"].Add(followedVlogger);
                        dict[followedVlogger]["followers"].Add(vlogger);
                    }
                }
            }

            int number = 1;

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            foreach (var kvp in dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["followed"].Count))
            {
                Console.WriteLine($"{number}. {kvp.Key} : {kvp.Value["followers"].Count} followers, {kvp.Value["followed"].Count} following");

                if (number == 1)
                {
                    foreach (var followers in kvp.Value["followers"])
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }

                number++;
            }
        }
    }
}
