using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLiquid = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var liquid = new Queue<int>(inputLiquid);

            var inputPhysical = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var physical = new Stack<int>(inputPhysical);

            var dict = new Dictionary<string, int>();
            dict["Glass"] = 0;
            dict["Aluminium"] = 0;
            dict["Lithium"] = 0;
            dict["Carbon fiber"] = 0;


            while (liquid.Count > 0 && physical.Count > 0)
            {
                int currentLiquid = liquid.Peek();
                int currentPhysical = physical.Peek();

                if (currentLiquid + currentPhysical == 25)
                {
                    dict["Glass"]++;

                    liquid.Dequeue();
                    physical.Pop();
                }  
                else if (currentLiquid + currentPhysical == 50)
                {
                    dict["Aluminium"]++;

                    liquid.Dequeue();
                    physical.Pop();
                }
                else if (currentLiquid + currentPhysical == 75)
                {
                    dict["Lithium"]++;

                    liquid.Dequeue();
                    physical.Pop();
                }
                else if (currentLiquid + currentPhysical == 100)
                {
                    dict["Carbon fiber"]++;

                    liquid.Dequeue();
                    physical.Pop();
                }
                else
                {
                    liquid.Dequeue();
                    int temp = physical.Pop();
                    physical.Push(temp + 3);
                }
            }

            bool allElementsCollected = true;

            foreach (var kvp in dict)
            {
                if (kvp.Value == 0)
                {
                    allElementsCollected = false;
                }
            }

            if (allElementsCollected)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else if (liquid.Count > 0)
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquid));
            }

            if (physical.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else if (physical.Count > 0)
            {
                Console.Write("Physical items left: ");
                Console.WriteLine(string.Join(", ", physical));
            }

            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
