using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    string digitsFind = FindDigits(text);
                    if (digitsFind.Length > 0)
                    {
                        Console.WriteLine(digitsFind);
                    }
                }
                else if (i == 1)
                {
                    string letterFind = FindLetters(text);
                    if (letterFind.Length > 0)
                    {
                        Console.WriteLine(letterFind);
                    }
                }
                else if (i == 2)
                {
                    string symbolsFind = FindSymbols(text);
                    if (symbolsFind.Length > 0)
                    {
                        Console.WriteLine(symbolsFind);
                    }
                }
            }
        }

        private static string FindSymbols(string text)
        {
            string result = string.Empty;
            foreach (var character in text)
            {
                if (char.IsSymbol(character))
                {
                    result += character;
                }
            }

            return result;
        }

        private static string FindLetters(string text)
        {
            string result = string.Empty;
            foreach (var character in text)
            {
                if (char.IsLetter(character))
                {
                    result += character;
                }
            }

            return result;
        }

        private static string FindDigits(string text)
        {
            string result = string.Empty;
            foreach (var character in text)
            {
                if (char.IsDigit(character))
                {
                    result += character;
                }
            }

            return result;
        }
    }
}
