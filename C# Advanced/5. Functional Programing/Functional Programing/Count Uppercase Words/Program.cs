using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = Console.ReadLine()
            //    .Split()
            //    .Where(w => Char.IsUpper(w[0]))
            //    .ToArray();

            //foreach (var word in arr)
            //{
            //    Console.WriteLine(word);
            //}

            Func<string, bool> func = w => //w[0] == w.ToUpper()[0];
            {
                if (w[0] == w.ToUpper()[0])
                {
                    return true;
                }
                return false;
            };

            var arr = Console.ReadLine()
                .Split()
                .Where(func)
                .ToArray();

            foreach (var word in arr)
            {
                Console.WriteLine(word);
            }
        }
    }
}
