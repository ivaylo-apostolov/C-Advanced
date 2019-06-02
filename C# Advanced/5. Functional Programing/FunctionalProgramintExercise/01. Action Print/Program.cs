using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = p => Console.WriteLine(p);

            var input = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
