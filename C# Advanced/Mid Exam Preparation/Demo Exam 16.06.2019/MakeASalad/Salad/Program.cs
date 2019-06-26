using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputVegetables = Console.ReadLine()
                .Split();
            var vegetables = new Queue<string>(inputVegetables);

            var inputSaladCalories = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            var saladCalories = new Stack<int>(inputSaladCalories);
            var fullSaladCalories = new Stack<int>(inputSaladCalories);

            var listSalads = new List<int>();

            while (saladCalories.Count > 0 && vegetables.Count > 0)
            {
                string vegetable = vegetables.Peek();
                int saladCalory = saladCalories.Peek();

                if (vegetable == "tomato")
                {
                    if (saladCalory <= 80)
                    {
                        listSalads.Add(fullSaladCalories.Pop());
                        saladCalories.Pop();
                        vegetables.Dequeue();
                    }
                    else
                    {
                        saladCalory -= 80;
                        saladCalories.Pop();
                        saladCalories.Push(saladCalory);
                        vegetables.Dequeue();
                    }
                }
                else if (vegetable == "carrot")
                {
                    if (saladCalory <= 136)
                    {
                        listSalads.Add(fullSaladCalories.Pop());
                        saladCalories.Pop();
                        vegetables.Dequeue();
                    }
                    else
                    {
                        saladCalory -= 136;
                        saladCalories.Pop();
                        saladCalories.Push(saladCalory);
                        vegetables.Dequeue();
                    }
                }
                else if (vegetable == "lettuce")
                {
                    if (saladCalory <= 109)
                    {
                        listSalads.Add(fullSaladCalories.Pop());
                        saladCalories.Pop();
                        vegetables.Dequeue();
                    }
                    else
                    {
                        saladCalory -= 109;
                        saladCalories.Pop();
                        saladCalories.Push(saladCalory);
                        vegetables.Dequeue();
                    }
                }
                else if (vegetable == "potato")
                {
                    if (saladCalory <= 215)
                    {
                        listSalads.Add(fullSaladCalories.Pop());
                        saladCalories.Pop();
                        vegetables.Dequeue();
                    }
                    else
                    {
                        saladCalory -= 215;
                        saladCalories.Pop();
                        saladCalories.Push(saladCalory);
                        vegetables.Dequeue();
                    }
                }
            }

            Console.WriteLine(string.Join(" ", listSalads));

            if (saladCalories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", fullSaladCalories));
            }
            else if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }
    }
}
