using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
