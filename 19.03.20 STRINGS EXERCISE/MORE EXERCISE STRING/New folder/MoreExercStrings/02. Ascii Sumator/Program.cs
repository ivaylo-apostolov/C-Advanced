using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            int sum = 0;

            foreach (var character in inputString)
            {
                char ch = character;

                if (firstChar < ch && ch < lastChar)
                {
                    int numberOfChar = (int)ch;
                    sum += numberOfChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
