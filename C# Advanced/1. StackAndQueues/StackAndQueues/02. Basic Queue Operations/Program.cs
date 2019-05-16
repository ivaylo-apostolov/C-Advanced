using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIntegers = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int numbersToRemove = inputIntegers[1];
            int numberToContains = inputIntegers[2];

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(input);

            for (int i = 0; i < numbersToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numberToContains))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
