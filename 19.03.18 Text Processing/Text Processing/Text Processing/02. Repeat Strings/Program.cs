using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                            .Split()
                            .ToArray();

            string resultString = string.Empty;

            foreach (var word in arr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    resultString += word;
                }
            }

            Console.WriteLine(resultString);
        }
    }
}
