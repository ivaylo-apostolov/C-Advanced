using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var list = new List<int>();
            var command = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                list.Add(i);
            }

            foreach (var number in list.Where(x => command == "odd" ? x % 2 != 0 : x % 2 == 0))
            {
                Console.Write(number + " ");
            }


        }
    }
}
