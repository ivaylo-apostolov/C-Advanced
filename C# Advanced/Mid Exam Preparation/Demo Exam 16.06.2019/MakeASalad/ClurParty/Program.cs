using System;
using System.Collections.Generic;
using System.Linq;

namespace ClurParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine()
                .Split();

            var stack = new Stack<string>(input);
            var dict = new Dictionary<char, List<int>>();
            var halls = new Queue<char>();

            while (stack.Count > 0)
            {
                string charOrInt = stack.Peek();

                if (char.IsLetter(charOrInt[0]))
                {
                    char hall = charOrInt[0];
                    
                    if (!dict.ContainsKey(hall))
                    {
                        dict[hall] = new List<int>();
                        halls.Enqueue(hall);
                        stack.Pop();
                    }
                }
                else if (char.IsDigit(charOrInt[0]))
                {
                    int peopleCount = int.Parse(charOrInt);
                    

                    if (halls.Count > 0)
                    {
                        char currentHall = halls.Peek();

                        if (dict[currentHall].Sum() + peopleCount <= capacity)
                        {
                            dict[currentHall].Add(peopleCount);
                            stack.Pop();

                            if (dict[currentHall].Sum() == capacity)
                            {
                                Console.Write($"{currentHall} -> ");
                                Console.WriteLine(string.Join(", ", dict[currentHall]));
                                dict.Remove(currentHall);
                                halls.Dequeue();
                            }
                        }
                        else if (dict[currentHall].Sum() + peopleCount > capacity)
                        {
                            Console.Write($"{currentHall} -> ");
                            Console.WriteLine(string.Join(", ", dict[currentHall]));
                            dict.Remove(currentHall);
                            halls.Dequeue();

                            if (halls.Count > 0)
                            {
                                dict[halls.Peek()].Add(peopleCount);
                            }

                            stack.Pop();
                        }
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
        }
    }
}
