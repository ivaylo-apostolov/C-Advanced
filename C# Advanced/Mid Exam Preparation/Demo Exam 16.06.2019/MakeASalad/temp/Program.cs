using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5] { 1, 2, 3, 4, 5 };

            var queue = new Queue<int>(arr);

            queue.Dequeue(); // remove 1
            queue = new Queue<int>(queue.Reverse());
            queue.Enqueue(9); // add 9
            queue = new Queue<int>(queue.Reverse());

            Console.WriteLine(queue.Dequeue()); // 9

            
        }
    }
}
