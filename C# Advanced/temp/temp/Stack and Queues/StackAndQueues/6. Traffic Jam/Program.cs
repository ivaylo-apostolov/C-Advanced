using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPassed = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();

            string input = string.Empty;
            int carsPass = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < carsPassed; i++)
                    {
                        if (queue.Count > 0)
                        {
                            carsPass++;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{carsPass} cars passed the crossroads.");
        }
    }
}
