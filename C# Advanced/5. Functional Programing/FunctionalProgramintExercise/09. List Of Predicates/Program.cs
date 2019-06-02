using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var div = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            foreach (var number in list)
            {
                bool isDivisible = Divisible(number, div);
                if (isDivisible)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }

        public static bool Divisible(int number, int[] arr)
        {
            foreach (var numb in arr)
            {
                if (number % numb != 0)
                {
                    return false;                    
                }                
            }
            return true;
        }
    }
}
