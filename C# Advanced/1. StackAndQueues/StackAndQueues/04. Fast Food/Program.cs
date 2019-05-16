using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            var inputOrders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var orders = new Queue<int>(inputOrders);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (quantityOfFood >= orders.Peek())
                {
                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
