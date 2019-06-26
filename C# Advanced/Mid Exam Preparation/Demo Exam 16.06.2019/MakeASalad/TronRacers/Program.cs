using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int firstR = -1;
            int firstC = -1;
            int secondR = -1;
            int secondC = -1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        firstR = row;
                        firstC = col;
                    }
                    if (matrix[row, col] == 's')
                    {
                        secondR = row;
                        secondC = col;
                    }
                }
            }

            bool isFirstDead = false;
            bool isSecondDead = false;

            while (!isFirstDead && !isSecondDead)
            {
                var tokens = Console.ReadLine()
                    .Split();

                string firstMove = tokens[0];
                string secondMove = tokens[1];

                if (firstMove == "up")
                {
                    if (firstR - 1 < 0)
                    {
                        firstR = n - 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        firstR -= 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                }
                else if (firstMove == "down")
                {
                    if (firstR + 1 == n)
                    {
                        firstR = 0;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        firstR += 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                }
                else if (firstMove == "left")
                {
                    if (firstC - 1 < 0)
                    {
                        firstC = n - 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        firstC -= 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                }
                else if (firstMove == "right")
                {
                    if (firstC + 1 == n)
                    {
                        firstC = 0;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        firstC += 1;

                        if (matrix[firstR, firstC] == '*')
                        {
                            matrix[firstR, firstC] = 'f';
                        }
                        else if (matrix[firstR, firstC] == 's')
                        {
                            matrix[firstR, firstC] = 'x';
                            break;
                        }
                    }
                }

                if (secondMove == "up")
                {
                    if (secondR - 1 < 0)
                    {
                        secondR = n - 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        secondR -= 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                }
                else if (secondMove == "down")
                {
                    if (secondR + 1 == n)
                    {
                        secondR = 0;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        secondR += 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                }
                else if (secondMove == "left")
                {
                    if (secondC - 1 < 0)
                    {
                        secondC = n - 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        secondC -= 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                }
                else if (secondMove == "right")
                {
                    if (secondC + 1 == n)
                    {
                        secondC = 0;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                    else
                    {
                        secondC += 1;

                        if (matrix[secondR, secondC] == '*')
                        {
                            matrix[secondR, secondC] = 's';
                        }
                        else if (matrix[secondR, secondC] == 'f')
                        {
                            matrix[secondR, secondC] = 'x';
                            break;
                        }
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
