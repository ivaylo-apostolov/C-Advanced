using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            int repeatCommands = int.Parse(Console.ReadLine());
            var stack = new Stack<string[]>();

            for (int i = 0; i < repeatCommands; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();

                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    string stringToAdd = input[1];
                    sb.Append(stringToAdd);
                    stack.Push(new string[] { input[0], input[1] });
                }
                else if (command == 2)
                {
                    int charsToRemove = int.Parse(input[1]);
                    string temp = sb.ToString();
                    string removedChars = temp.Substring(temp.Length - charsToRemove);

                    stack.Push(new string[] { input[0], removedChars });
                    sb.Remove(sb.Length - charsToRemove, charsToRemove);
                    
                }
                else if (command == 3)
                {
                    int indexPosition = int.Parse(input[1]);
                    Console.WriteLine(sb[indexPosition - 1]);
                }
                else if (command == 4)
                {
                    var lastCommand = stack.Peek();
                    string commandToUndo = lastCommand[0];
                    if (commandToUndo == "1")
                    {
                        string charToRemove = lastCommand[1];
                        sb.Replace(charToRemove, "");
                        stack.Pop();
                    }
                    else if (commandToUndo == "2")
                    {
                        string charToAdd = lastCommand[1];
                        sb.Append(charToAdd);
                    }
                }
            }
        }
    }
}
