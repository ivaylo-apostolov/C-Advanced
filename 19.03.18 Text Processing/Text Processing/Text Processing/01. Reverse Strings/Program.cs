using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string reverseString = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverseString += input[i];
                }

                Console.WriteLine($"{input} = {reverseString}");
            }
        }
    }
}
