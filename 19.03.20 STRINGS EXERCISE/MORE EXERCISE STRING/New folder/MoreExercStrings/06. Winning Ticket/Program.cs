using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            

            foreach (var token in tokens)
            {
                if (token.Length == 20)
                {
                    string leftHalf = token.Substring(0, token.Length / 2);
                    string rightHalf = token.Substring(token.Length / 2);

                    if (Regex.IsMatch(leftHalf, @"[\$]{6,}") && Regex.IsMatch(rightHalf, @"[\$]{6,}"))
                    {
                        var matchLeft = Regex.Match(leftHalf, @"[\$]{6,}");
                        string leftSymbols = matchLeft.Value;

                        var matchRight = Regex.Match(rightHalf, @"[\$]{6,}");
                        string rightSymbols = matchRight.Value;

                        if (leftSymbols.Length == rightSymbols.Length)
                        {
                            char ch = '"';

                            if (leftSymbols.Length == 10)
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - 10$ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - {leftSymbols.Length}$");
                            }
                        }
                    }
                    else if (Regex.IsMatch(leftHalf, @"[\#]{6,}") && Regex.IsMatch(rightHalf, @"[\#]{6,}"))
                    {
                        var matchLeft = Regex.Match(leftHalf, @"[\#]{6,}");
                        string leftSymbols = matchLeft.Value;

                        var matchRight = Regex.Match(rightHalf, @"[\#]{6,}");
                        string rightSymbols = matchRight.Value;

                        if (leftSymbols.Length == rightSymbols.Length)
                        {
                            char ch = '"';

                            if (leftSymbols.Length == 10)
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - 10# Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - {leftSymbols.Length}#");
                            }
                        }
                    }
                    else if (Regex.IsMatch(leftHalf, @"[\@]{6,}") && Regex.IsMatch(rightHalf, @"[\@]{6,}"))
                    {
                        var matchLeft = Regex.Match(leftHalf, @"[\@]{6,}");
                        string leftSymbols = matchLeft.Value;

                        var matchRight = Regex.Match(rightHalf, @"[\@]{6,}");
                        string rightSymbols = matchRight.Value;

                        if (leftSymbols.Length == rightSymbols.Length)
                        {
                            char ch = '"';

                            if (leftSymbols.Length == 10)
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - 10@ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - {leftSymbols.Length}@");
                            }
                        }
                    }
                    else if (Regex.IsMatch(leftHalf, @"[\^]{6,}") && Regex.IsMatch(rightHalf, @"[\^]{6,}"))
                    {
                        var matchLeft = Regex.Match(leftHalf, @"[\^]{6,}");
                        string leftSymbols = matchLeft.Value;

                        var matchRight = Regex.Match(rightHalf, @"[\^]{6,}");
                        string rightSymbols = matchRight.Value;

                        if (leftSymbols.Length == rightSymbols.Length)
                        {
                            char ch = '"';

                            if (leftSymbols.Length == 10)
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - 10^ Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket {ch}{token}{ch} - {leftSymbols.Length}^");
                            }
                        }
                    }
                    else
                    {
                        char ch = '"';
                        Console.WriteLine($"ticket {ch}{token}{ch} - no match");
                    }

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
