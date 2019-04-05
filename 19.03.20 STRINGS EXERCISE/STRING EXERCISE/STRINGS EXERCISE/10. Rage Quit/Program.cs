using System;
using System.Collections.Generic;

namespace _10._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var list = new List<char>();

            foreach (var character in input)
            {
                char ch = ' ';
                if (!char.IsDigit(character))
                {
                    ch = character;
                }
                
                

            }
        }
    }
}
