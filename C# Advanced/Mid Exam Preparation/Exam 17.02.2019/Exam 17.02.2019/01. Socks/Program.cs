using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLeftSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var leftSocks = new Stack<int>(inputLeftSocks);

            var inputRightSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var rightSocks = new Queue<int>(inputRightSocks);

            var pairs = new List<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    pairs.Add(leftSock + rightSock);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (leftSock == rightSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(leftSocks.Pop() + 1);
                }
                else if (leftSock < rightSock)
                {
                    leftSocks.Pop();
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
