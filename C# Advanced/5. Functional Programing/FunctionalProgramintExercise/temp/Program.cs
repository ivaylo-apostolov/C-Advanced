using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .ToList();

            arr = AddFilterLenght(arr, 3);

            Console.WriteLine(string.Join(" ", arr));
        }

        public static List<string> AddFilterLenght(List<string> list, int lenght)
        {
            return list
                .Where(x => x.Length != lenght)
                .ToList();
        }
    }
}
