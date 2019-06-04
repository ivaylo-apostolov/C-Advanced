using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCharacterLength = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var name in names)
            {
                if (IsThisNameLongerThan(inputCharacterLength, name, SymbolsAndName))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }

        public static bool IsThisNameLongerThan(int num, string name, Func<int, string, bool> operation)
        {
            return operation(num, name);
        }
        public static bool SymbolsAndName(int number, string name)
        {
            int count = 0;

            foreach (var symbol in name)
            {
                count += symbol;
            }

            if (count >= number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Func<int, string, bool> SymbolsAndName = (number, name) =>
        //{
        //    int count = 0;

        //    foreach (var symbol in name)
        //    {
        //        count += symbol;
        //    }

        //    if (count >= number)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //};
    }
}
