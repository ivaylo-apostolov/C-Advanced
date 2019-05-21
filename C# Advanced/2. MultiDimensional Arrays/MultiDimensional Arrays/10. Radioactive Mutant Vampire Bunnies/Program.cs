using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[inputSize[0], inputSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var tokens = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[col].ToString();
                }
            }

            string playerMoves = Console.ReadLine();
            int posRow = 0;
            int posCol = 0;
            bool isWin = false;
            bool isDead = false;

            for (int i = 0; i < playerMoves.Length; i++)
            {
                string moveDirection = playerMoves[i].ToString();
                

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        if (matrix[row, col] == "P")
                        {
                            posRow = row;
                            posCol = col;
                        }
                    }
                }

                if (moveDirection == "U")
                {
                    if (posRow - 1 < 0)
                    {
                        isWin = true;
                        matrix[posRow, posCol] = ".";
                    }

                    if (matrix[posRow - 1, posCol] == ".")
                    {
                        if (!isWin)
                        {
                            matrix[posRow - 1, posCol] = "P";
                        }
                        
                        matrix[posRow, posCol] = ".";
                        posRow -= 1;
                    }
                    else if (matrix[posRow - 1, posCol] == "B")
                    {
                        matrix[posRow, posCol] = ".";
                        isDead = true;
                    }
                }
                else if (moveDirection == "D")
                {
                    if (posRow + 1 == matrix.GetLength(0))
                    {
                        isWin = true;
                        matrix[posRow, posCol] = ".";
                    }

                    if (matrix[posRow + 1, posCol] == ".")
                    {
                        if (!isWin)
                        {
                            matrix[posRow + 1, posCol] = "P";
                        }
                        
                        matrix[posRow, posCol] = ".";
                        posRow += 1;
                    }
                    else if (matrix[posRow - 1, posCol] == "B")
                    {
                        matrix[posRow, posCol] = ".";
                        isDead = true;
                    }
                }
                else if (moveDirection == "L")
                {
                    if (posCol - 1 < 0)
                    {
                        isWin = true;
                        matrix[posRow, posCol] = ".";
                    }

                    if (matrix[posRow , posCol - 1] == ".")
                    {
                        if (!isWin)
                        {
                            matrix[posRow, posCol - 1] = "P";
                        }                        
                        matrix[posRow, posCol] = ".";
                        posCol -= 1;
                    }
                    else if (matrix[posRow, posCol - 1] == "B")
                    {
                        matrix[posRow, posCol] = ".";
                        isDead = true;
                    }
                }
                else if (moveDirection == "R")
                {
                    if (posCol + 1 == matrix.GetLength(1))
                    {
                        isWin = true;
                        matrix[posRow, posCol] = ".";
                    }

                    if (matrix[posRow, posCol + 1] == ".")
                    {
                        if (!isWin)
                        {
                            matrix[posRow, posCol + 1] = "P";
                        }
                        matrix[posRow, posCol] = ".";
                        posCol += 1;
                    }
                    else if (matrix[posRow, posCol + 1] == "B")
                    {
                        matrix[posRow, posCol] = ".";
                        isDead = true;
                    }
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == "B")
                        {
                            if (row - 1 >= 0)
                            {
                                if (matrix[row - 1, col] == "P")
                                {
                                    isDead = true;
                                }

                                matrix[row - 1, col] = "B";
                            }
                            if (row + 1 < matrix.GetLength(0))
                            {
                                if (matrix[row + 1, col] == "P")
                                {
                                    isDead = true;
                                }

                                matrix[row + 1, col] = "B";
                            }
                            if (col - 1 >= 0)
                            {
                                if (matrix[row, col - 1] == "P")
                                {
                                    isDead = true;
                                }

                                matrix[row, col - 1] = "B";
                            }
                            if (col + 1 < matrix.GetLength(1))
                            {
                                if (matrix[row, col + 1] == "P")
                                {
                                    isDead = true;
                                }

                                matrix[row, col + 1] = "B";
                            }
                        }
                    }
                }

                if (isDead || isWin)
                {
                    break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            if (isWin)
            {
                Console.WriteLine("won");
                //TODO last possitioon before got out
            }
            else if (isDead)
            {
                Console.WriteLine("dead");
                //TODO last possitioon before died
            }
        }
    }
}
