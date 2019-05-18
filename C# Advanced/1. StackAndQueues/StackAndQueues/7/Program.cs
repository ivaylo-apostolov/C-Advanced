using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPomps = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < numberOfPomps; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int quantity = input[0];
                int distance = input[1];

                queue.Enqueue(new int[] { quantity, distance });
            }

            int index = 0;
            bool isComplite = false;

            while(!isComplite)
            {
                int tankQuantity = 0;

                for (int i = 0; i < numberOfPomps; i++)
                {
                    var arr = queue.Peek();
                    int currentQuantity = arr[0];
                    int currentDistance = arr[1];
                    tankQuantity += currentQuantity;

                    if (tankQuantity >= currentDistance)
                    {
                        tankQuantity -= currentDistance;
                        queue.Enqueue(queue.Dequeue());
                    }
                    else
                    {
                        for (int j = i; j < numberOfPomps; j++)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }

                        index++;
                        queue.Enqueue(queue.Dequeue());
                        break;
                    }

                    if (i == numberOfPomps - 1 && tankQuantity >= 0)
                    {
                        isComplite = true;
                    }
                }
                
            }

            Console.WriteLine(index);
        }
    }
}
