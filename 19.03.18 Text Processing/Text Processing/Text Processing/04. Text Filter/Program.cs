using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToReplace = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var text = Console.ReadLine();

            foreach (var word in stringToReplace)
            {
                string replaceString = new string('*', word.Length);
                while (text.Contains(word))
                {
                    text = text.Replace(word, replaceString);
                }
                
            }

            Console.WriteLine(text);
        }
    }
}
