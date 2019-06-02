using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string comm = string.Empty;

            while ((comm = Console.ReadLine()) != "end")
            {
                if (comm == "add")
                {
                    numbers = Operation(numbers, Add);
                }
                else if (comm == "multiply")
                {
                    numbers = Operation(numbers, Multiply);
                }
                else if (comm == "subtract")
                {
                    numbers = Operation(numbers, Subtract);
                }
                else if (comm == "print")
                {
                    Print(numbers);
                }
            }
        }

        public static List<int> Operation(List<int> collection, Func<List<int>, List<int>> operation)
        {
            return operation(collection);
        }

        public static List<int> Add(List<int> collection)
        {
            var list = new List<int>();

            foreach (var number in collection)
            {
                list.Add(number + 1);
            }

            return list;
        }

        public static List<int> Multiply(List<int> collection)
        {
            var list = new List<int>();

            foreach (var number in collection)
            {
                list.Add(number * 2);
            }

            return list;
        }

        public static List<int> Subtract(List<int> collection)
        {
            var list = new List<int>();

            foreach (var number in collection)
            {
                list.Add(number - 1);
            }

            return list;
        }

        public static void Print(List<int> collection)
        {
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
