using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            int inputNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumbers; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var command = input[0];

                if (command == 1)
                {
                    int numberToPush = input[1];
                    stack.Push(numberToPush);
                }
                else if (command == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
