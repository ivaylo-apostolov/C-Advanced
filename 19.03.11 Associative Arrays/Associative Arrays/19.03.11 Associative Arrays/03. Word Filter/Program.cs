using System;
using System.Linq;

namespace _03._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
