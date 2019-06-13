using System;

namespace Generics_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", ArrayCreator.ArrCreator<string>(5, "Ivo")));
        }
    }
}
