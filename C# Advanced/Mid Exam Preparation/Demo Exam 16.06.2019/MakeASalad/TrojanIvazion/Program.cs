using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanIvazion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            var inputPlate = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var plate = new Queue<int>(inputPlate);
            var warriors = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                if (plate.Count == 0)
                {
                    break;
                }
                else
                {
                    warriors.Clear();
                }

                var inputWariors = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                foreach (var warrior in inputWariors)
                {
                    warriors.Push(warrior);
                }

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plate.Enqueue(newPlate);
                }

                while (true)
                {
                    if (plate.Count == 0 || warriors.Count == 0)
                    {
                        break;
                    }

                    int attack = warriors.Peek();
                    int defence = plate.Peek();

                    if (attack > defence)
                    {
                        attack -= defence;
                        warriors.Pop();
                        warriors.Push(attack);
                        plate.Dequeue();
                    }
                    else if (attack == defence)
                    {
                        warriors.Pop();
                        plate.Dequeue();
                    }
                    else if (attack < defence)
                    {
                        defence -= attack;
                        warriors.Pop();
                        plate.Dequeue();
                        plate = new Queue<int>(plate.Reverse());
                        plate.Enqueue(defence);
                        plate = new Queue<int>(plate.Reverse());
                    }
                }
            }

            if (warriors.Count > 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.Write("Warriors left: ");
                Console.WriteLine(string.Join(", ", warriors));
            }
            else if (plate.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.Write("Plates left: ");
                Console.WriteLine(string.Join(", ", plate));
            }
        }
    }
}
