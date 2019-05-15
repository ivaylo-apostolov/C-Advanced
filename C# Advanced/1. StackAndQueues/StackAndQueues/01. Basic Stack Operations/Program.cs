using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberToPush = input[0];
            int numberToPop = input[1];
            int numberToContain = input[2];

            var inputNumberToPush = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var stack = new Stack<int>(inputNumberToPush);

            for (int i = 0; i < numberToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToContain))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
