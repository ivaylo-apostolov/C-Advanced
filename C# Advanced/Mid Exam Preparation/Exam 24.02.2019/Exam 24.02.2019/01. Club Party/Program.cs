using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var tokens = Console.ReadLine()
                .Split()
                .ToArray();

            var stack = new Stack<string>(tokens);

            var dict = new Dictionary<string, List<int>>();

            var queue = new Queue<string>();

            bool isFull = false;

            while (stack.Count > 0)
            {
                var symbol = stack.Pop();
                string currentHall = string.Empty;
                int currentReserve = 0;

                if (char.IsLetter(symbol[0]))
                {
                    currentHall = symbol;

                    if (!queue.Contains(currentHall))
                    {
                        queue.Enqueue(currentHall);

                        if (!dict.ContainsKey(currentHall))
                        {
                            dict[currentHall] = new List<int>();
                        }
                    }                    
                }
                else
                {
                    currentReserve = int.Parse(symbol);

                    if (queue.Count > 0 && dict[queue.Peek()].Sum() + currentReserve <= capacity)
                    {
                        dict[queue.Peek()].Add(currentReserve);
                    }
                    else if (queue.Count > 0 && dict[queue.Peek()].Sum() + currentReserve > capacity)
                    {
                        Console.Write($"{queue.Peek()} -> ");
                        Console.WriteLine(string.Join(", ", dict[queue.Peek()]));
                        dict.Remove(queue.Dequeue());

                        if (queue.Count > 0)
                        {
                            dict[queue.Peek()].Add(currentReserve);
                        }
                    }
                }
            }
        }
    }
}
