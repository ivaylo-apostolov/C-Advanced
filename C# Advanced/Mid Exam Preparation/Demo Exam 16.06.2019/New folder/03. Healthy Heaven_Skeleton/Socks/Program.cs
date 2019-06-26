using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLeft = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var left = new Stack<int>(inputLeft);

            var inputRight = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var right = new Queue<int>(inputRight);

            var pairs = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                int currentLeft = left.Peek();
                int currentRight = right.Peek();

                if (currentLeft > currentRight)
                {
                    pairs.Add(currentRight + currentLeft);
                    left.Pop();
                    right.Dequeue();
                }
                else if (currentLeft == currentRight)
                {
                    right.Dequeue();
                    int temp = left.Pop();
                    left.Push(temp + 1);
                }
                else if (currentLeft < currentRight)
                {
                    left.Pop();
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
