using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenTimesRepitedNumber = 0;
            var set = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!set.Contains(number))
                {
                    set.Add(number);
                }
                else
                {
                    evenTimesRepitedNumber = number;
                    break;
                }
            }

            Console.WriteLine(evenTimesRepitedNumber);
        }
    }
}
