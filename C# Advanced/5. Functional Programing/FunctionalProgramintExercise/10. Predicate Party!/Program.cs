using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input
                    .Split()
                    .ToArray();

                var command = tokens[0];
                var type = tokens[1];
                var patern = tokens[2];

                if (command == "Remove")
                {
                    if (type == "StartsWith")
                    {
                        list = list
                            .Where(x => x.StartsWith(patern) != true)
                            .ToList();
                    }
                    else if (type == "EndsWith")
                    {
                        list = list
                            .Where(x => x.EndsWith(patern) != true)
                            .ToList();
                    }
                    else if (type == "Length")
                    {
                        list = list
                            .Where(x => x.Length != int.Parse(patern))
                            .ToList();
                    }
                }
                else if (command == "Double")
                {
                    if (type == "StartsWith")
                    {
                        list = list
                            .Select(x => x.StartsWith(patern) ? x = ($"{x}, {x}").ToString() : x)
                            .ToList();
                    }
                    else if (type == "EndsWith")
                    {
                        list = list
                            .Select(x => x.EndsWith(patern) ? x = ($"{x}, {x}").ToString() : x)
                            .ToList();
                    }
                    else if (type == "Length")
                    {
                        list = list
                            .Select(x => x.Length == int.Parse(patern) ? x = ($"{x}, {x}").ToString() : x)
                            .ToList();
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", list) + " are going to the party!");
            }
        }
    }
}
