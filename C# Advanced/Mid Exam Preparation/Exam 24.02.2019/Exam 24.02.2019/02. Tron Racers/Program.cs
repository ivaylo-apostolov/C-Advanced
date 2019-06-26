using System;
using System.Linq;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            PopulateMatrix(ref matrix);

            int fRow = -1;
            int fCol = -1;
            LocateSymbol(ref fRow, ref fCol, matrix, 'f');

            int sRow = -1;
            int sCol = -1;
            LocateSymbol(ref sRow, ref sCol, matrix, 's');

            bool isDead = false;

            int counter = 0;

            while (!isDead)
            {
                var inputMoves = Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstMove = inputMoves[0];
                string secondMove = inputMoves[1];

                if (firstMove == "up")
                {
                    MoveUp(ref matrix, ref fRow, ref fCol, ref isDead, 'f', 's');
                }
                else if (firstMove == "down")
                {
                    MoveDown(ref matrix, ref fRow, ref fCol, ref isDead, 'f', 's');
                }
                else if (firstMove == "left")
                {
                    MoveLeft(ref matrix, ref fRow, ref fCol, ref isDead, 'f', 's');
                }
                else if (firstMove == "right")
                {
                    MoveRight(ref matrix, ref fRow, ref fCol, ref isDead, 'f', 's');
                }

                if (isDead)
                {
                    break;
                }

                if (secondMove == "up")
                {
                    MoveUp(ref matrix, ref sRow, ref sCol, ref isDead, 's', 'f');
                }
                else if (secondMove == "down")
                {
                    MoveDown(ref matrix, ref sRow, ref sCol, ref isDead, 's', 'f');
                }
                else if (secondMove == "left")
                {
                    MoveLeft(ref matrix, ref sRow, ref sCol, ref isDead, 's', 'f');
                }
                else if (secondMove == "right")
                {
                    MoveRight(ref matrix, ref sRow, ref sCol, ref isDead, 's', 'f');
                }

                counter++;
                if (counter > 20)
                {
                    break;
                }
            }            

            PrintMatrix(matrix);
        }

        public static void MoveLeft(ref char[,] matrix, ref int symbolRow, ref int symbolCol, ref bool isDead,
            char moveSymbol, char staySymbol)
        {
            if (matrix[symbolRow, symbolCol - 1] == '*')
            {
                matrix[symbolRow, symbolCol - 1] = moveSymbol;
                symbolCol -= 1;
            }
            else if (matrix[symbolRow, symbolCol - 1] == staySymbol)
            {
                matrix[symbolRow, symbolCol - 1] = 'x';
                isDead = true;
            }
            else if (symbolCol - 1 < 0)
            {
                if (matrix[symbolRow, matrix.GetLength(1) - 1] == '*')
                {
                    matrix[symbolRow, matrix.GetLength(1) - 1] = moveSymbol;
                }
                else if (matrix[symbolRow, matrix.GetLength(1) - 1] == staySymbol)
                {
                    matrix[symbolRow, matrix.GetLength(1) - 1] = 'x';
                    isDead = true;
                }

                symbolCol = matrix.GetLength(1) - 1;
            }
        }

        public static void MoveRight(ref char[,] matrix, ref int symbolRow,
            ref int symbolCol, ref bool isDead, char moveSymbol, char staySymbol)
        {
            if (matrix[symbolRow, symbolCol + 1] == '*')
            {
                matrix[symbolRow, symbolCol + 1] = moveSymbol;
                symbolCol += 1;
            }
            else if (matrix[symbolRow, symbolCol + 1] == staySymbol)
            {
                matrix[symbolRow, symbolCol + 1] = 'x';
                isDead = true;
            }
            else if (symbolCol + 1 == matrix.GetLength(1))
            {
                if (matrix[symbolRow, 0] == '*')
                {
                    matrix[symbolRow, 0] = moveSymbol;
                }
                else if (matrix[symbolRow, 0] == staySymbol)
                {
                    matrix[symbolRow, 0] = 'x';
                    isDead = true;
                }

                symbolCol = 0;
            }
        }

        public static void MoveUp(ref char[,] matrix, ref int symbolRow,
            ref int symbolCol, ref bool isDead, char moveSymbol, char staySymbol)
        {
            if (matrix[symbolRow - 1, symbolCol] == '*')
            {
                matrix[symbolRow - 1, symbolCol] = moveSymbol;
                symbolRow -= 1;
            }
            else if (matrix[symbolRow - 1, symbolCol] == staySymbol)
            {
                matrix[symbolRow - 1, symbolCol] = 'x';
                isDead = true;
            }
            else if (symbolRow - 1 < 0)
            {
                if (matrix[matrix.GetLength(0) - 1, symbolCol] == '*')
                {
                    matrix[matrix.GetLength(0) - 1, symbolCol] = moveSymbol;
                }
                else if (matrix[matrix.GetLength(0) - 1, symbolCol] == staySymbol)
                {
                    matrix[matrix.GetLength(0) - 1, symbolCol] = 'x';
                    isDead = true;
                }

                symbolRow = matrix.GetLength(0) - 1;
            }
        }

        public static void MoveDown(ref char[,] matrix, ref int symbolRow,
            ref int symbolCol, ref bool isDead, char moveSymbol, char staySymbol)
        {
            if (matrix[symbolRow + 1, symbolCol] == '*')
            {
                matrix[symbolRow + 1, symbolCol] = moveSymbol;
                symbolRow += 1;
            }
            else if (matrix[symbolRow + 1, symbolCol] == staySymbol)
            {
                matrix[symbolRow + 1, symbolCol] = 'x';
                isDead = true;
            }
            else if (symbolRow + 1 == matrix.GetLength(0))
            {
                if (matrix[0, symbolCol] == '*')
                {
                    matrix[0, symbolCol] = moveSymbol;
                }
                else if (matrix[0, symbolCol] == staySymbol)
                {
                    matrix[0, symbolCol] = 'x';
                    isDead = true;
                }

                symbolRow = 0;
            }
        }

        public static void PopulateMatrix(ref char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void LocateSymbol(ref int symbolRow, ref int symbolCol, char[,] matrix, char symbolToFind)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbolToFind)
                    {
                        symbolRow = row;
                        symbolCol = col;
                    }
                }
            }
        }
    }
}
