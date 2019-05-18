using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            int carPass = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green" && queue.Count > 0)
                {
                    string carInCrossroad = string.Empty;
                    carInCrossroad = queue.Peek();
                    var oneCar = new Queue<char>(queue.Dequeue());

                    for (int i = 0; i < greenLight; i++)
                    {
                        if (oneCar.Count > 0)
                        {
                            oneCar.Dequeue();

                            if (oneCar.Count == 0)
                            {
                                carPass++;
                            }
                        }
                        else if(oneCar.Count == 0 && queue.Count > 0)
                        {
                            carInCrossroad = queue.Peek();
                            string nextCar = queue.Dequeue();

                            foreach (var ch in nextCar)
                            {
                                oneCar.Enqueue(ch);
                            }

                            oneCar.Dequeue();
                        }
                    }

                    for (int i = 0; i < freeWindow; i++)
                    {
                        if (oneCar.Count == 0 && i == 0)
                        {
                            break;
                        }
                        else if (oneCar.Count > 0)
                        {
                            oneCar.Dequeue();
                        }
                        else if (oneCar.Count == 0)
                        {
                            carPass++;
                            break;
                        }
                    }

                    if (oneCar.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{carInCrossroad} was hit at {oneCar.Peek()}.");
                        return;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carPass} total cars passed the crossroads.");
        }
    }
}
