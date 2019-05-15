using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _2._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .ToArray();

            var stack = new Stack<string>(arr.Reverse());

            while(stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operant = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (operant == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (operant == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
