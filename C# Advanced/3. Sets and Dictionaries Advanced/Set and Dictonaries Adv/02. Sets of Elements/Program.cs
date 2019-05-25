using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lengthFirstSet = input[0];
            int lengthSecondSet = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < lengthFirstSet; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());

                firstSet.Add(numberToAdd);
            }

            for (int i = 0; i < lengthSecondSet; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());

                secondSet.Add(numberToAdd);            
            }

            var finalSet = new HashSet<int>();

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    finalSet.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}
