using System;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(n => n.Trim())
                .Select(Parse)
                .ToArray();

            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Sum());
        }

        public static Func<string, int> Parse = n => int.Parse(n);
    }
}
