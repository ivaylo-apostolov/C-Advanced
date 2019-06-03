using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .ToList();

            var dict = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            var filterType = string.Empty;
            var pattern = string.Empty;

            while (true)
            {
                var inputCommand = Console.ReadLine()
                    .Split(";")
                    .ToArray();

                var command = inputCommand[0];                

                if (command == "Print")
                {
                    foreach (var kvp in dict)
                    {
                        foreach (var kvp2 in kvp.Value)
                        {
                            if (kvp2.Key == "Starts with")
                            {
                                foreach (var pat in kvp2.Value)
                                {
                                    list = AddFilterStartsWith(list, pat);
                                }
                            }
                            else if (kvp2.Key == "Ends with")
                            {
                                foreach (var pat in kvp2.Value)
                                {
                                    list = AddFilterEndssWith(list, pat);
                                }
                            }
                            else if (kvp2.Key == "Length")
                            {
                                foreach (var pat in kvp2.Value)
                                {
                                    list = AddFilterLenght(list, int.Parse(pat));
                                }
                            }
                            else if (kvp2.Key == "Contains")
                            {
                                foreach (var pat in kvp2.Value)
                                {
                                    list = AddFilterContains(list, pat);
                                }
                            }
                        }
                    }

                    Print(list);
                    return;
                }

                if (command == "Add filter")
                {
                    filterType = inputCommand[1];
                    pattern = inputCommand[2];

                    if (!dict.ContainsKey(command))
                    {
                        dict[command] = new Dictionary<string, HashSet<string>>();
                    }

                    if (filterType == "Starts with")
                    {
                        if (!dict[command].ContainsKey(filterType))
                        {
                            dict[command][filterType] = new HashSet<string>();
                        }

                        dict[command][filterType].Add(pattern);
                    }
                    else if (filterType == "Ends with")
                    {
                        if (!dict[command].ContainsKey(filterType))
                        {
                            dict[command][filterType] = new HashSet<string>();
                        }

                        dict[command][filterType].Add(pattern);
                    }
                    else if (filterType == "Length")
                    {
                        if (!dict[command].ContainsKey(filterType))
                        {
                            dict[command][filterType] = new HashSet<string>();
                        }

                        dict[command][filterType].Add(pattern);
                    }
                    else if (filterType == "Contains")
                    {
                        if (!dict[command].ContainsKey(filterType))
                        {
                            dict[command][filterType] = new HashSet<string>();
                        }

                        dict[command][filterType].Add(pattern);
                    }
                }
                else if (command == "Remove filter")
                {
                    filterType = inputCommand[1];
                    pattern = inputCommand[2];

                    if (filterType == "Starts with")
                    {
                        if (dict.ContainsKey("Add filter") && dict["Add filter"].ContainsKey("Starts with"))
                        {
                            dict["Add filter"]["Starts with"].Remove(pattern);
                        }
                    }
                    else if (filterType == "Ends with")
                    {
                        if (dict.ContainsKey("Add filter") && dict["Add filter"].ContainsKey("Ends with"))
                        {
                            dict["Add filter"]["Ends with"].Remove(pattern);
                        }
                    }
                    else if (filterType == "Length")
                    {
                        if (dict.ContainsKey("Add filter") && dict["Add filter"].ContainsKey("Length"))
                        {
                            dict["Add filter"]["Length"].Remove(pattern);
                        }
                    }
                    else if (filterType == "Contains")
                    {
                        if (dict.ContainsKey("Add filter") && dict["Add filter"].ContainsKey("Contains"))
                        {
                            dict["Add filter"]["Contains"].Remove(pattern);
                        }
                    }
                }

            }
        }

        public static List<string> AddFilterStartsWith(List<string> list, string pattern)
        {
            return list
                .Where(x => x.StartsWith(pattern) != true)
                .ToList();
        }

        public static List<string> AddFilterEndssWith(List<string> list, string pattern)
        {
            return list
                .Where(x => x.EndsWith(pattern) != true)
                .ToList();
        }

        public static List<string> AddFilterLenght(List<string> list, int lenght)
        {
            return list
                .Where(x => x.Length != lenght)
                .ToList();
        }

        public static List<string> AddFilterContains(List<string> list, string contains)
        {
            return list
                .Where(x => x.Contains(contains) != true)
                .ToList();
        }

        public static void Print(List<string> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}


