using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumPrimaryDiagonal += matrix[row, col];
                    }

                    if (row + col == n - 1)
                    {
                        sumSecondaryDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }
    }
}
