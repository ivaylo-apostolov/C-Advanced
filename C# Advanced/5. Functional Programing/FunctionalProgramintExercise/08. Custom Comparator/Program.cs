using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x % 2 != 0)
                .ThenBy(x => x % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
