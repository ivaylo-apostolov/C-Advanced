using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _5._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var repeatTimes = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(names);

            while (queue.Count != 1)
            {
                for (int i = 1; i < repeatTimes; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
