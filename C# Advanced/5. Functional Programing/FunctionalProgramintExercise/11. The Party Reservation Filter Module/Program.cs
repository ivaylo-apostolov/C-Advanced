using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            //It should add dictionary to keep all commands. 
            //Now the program doesn't work

            var list = Console.ReadLine()
                .Split()
                .ToList();

            bool startsWith = false;
            bool endsWith = false;
            bool lenght = false;
            bool contains = false;

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
                    if (startsWith)
                    {
                        AddFilterStartsWith(list, pattern);
                    }
                    if (endsWith)
                    {
                        AddFilterEndssWith(list, pattern);
                    }
                    if (lenght)
                    {
                        AddFilterLenght(list, int.Parse(pattern));
                    }
                    if (contains)
                    {
                        AddFilterContains(list, pattern);
                    }
                    Print(list);
                    return;
                }

                if (command == "Add filter")
                {
                    filterType = inputCommand[1];
                    pattern = inputCommand[2];

                    if (filterType == "Starts with")
                    {
                        startsWith = true;
                    }
                    else if (filterType == "Ends with")
                    {
                        endsWith = true;
                    }
                    else if (filterType == "Length")
                    {
                        lenght = true;
                    }
                    else if (filterType == "Contains")
                    {
                        contains = true;
                    }
                }
                else if (command == "Remove filter")
                {
                    filterType = inputCommand[1];
                    pattern = inputCommand[2];

                    if (filterType == "StartsWith")
                    {
                        startsWith = false;
                    }
                    else if (filterType == "EndsWith")
                    {
                        endsWith = false;
                    }
                    else if (filterType == "Length")
                    {
                        lenght = false;
                    }
                    else if (filterType == "Contains")
                    {
                        contains = false;
                    }
                }

            }
        }

        public static void AddFilterStartsWith(List<string> list, string pattern)
        {
            list
                .Where(x => x.StartsWith(pattern) != true)
                .ToList();
        }

        public static void AddFilterEndssWith(List<string> list, string pattern)
        {
            list
                .Where(x => x.EndsWith(pattern) != true)
                .ToList();
        }

        public static void AddFilterLenght(List<string> list, int lenght)
        {
            list
                .Where(x => x.Length != lenght)
                .ToList();
        }

        public static void AddFilterContains(List<string> list, string contains)
        {
            list
                .Where(x => x.Contains(contains) != true)
                .ToList();
        }

        public static void Print(List<string> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}


