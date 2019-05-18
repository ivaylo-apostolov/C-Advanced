using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            bool isBalanced = true;
            bool turn = false;

            foreach (var character in input)
            {
                if (character == '{' || character == '(' || character == '[' || character == ' ' && !turn)
                {
                    stack.Push(character);
                }
                else if (character == '}' || character == ')' || character == ']' || character ==' ')
                {
                    turn = true;
                    if (character == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (character == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (character == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (character == ' ' && stack.Peek() == ' ')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
