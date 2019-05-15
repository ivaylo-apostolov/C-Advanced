using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var st = new Stack<char>();

            foreach (var ch in input)
            {
                st.Push(ch);
            }

            while (st.Count > 0)
            {
                Console.Write(st.Pop());
            }

            Console.WriteLine();
        }
    }
}
