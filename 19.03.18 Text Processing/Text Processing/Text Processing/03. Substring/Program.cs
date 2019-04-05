using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                text = text.Replace(key, string.Empty);
            }

            Console.WriteLine(text);

        }
    }
}
