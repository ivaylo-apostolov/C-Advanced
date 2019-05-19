using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[matrixSize[0], matrixSize[1]];

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

            int maxSum = int.MinValue;
            var indexOfMaxSum = new int[2];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexOfMaxSum[0] = row;
                        indexOfMaxSum[1] = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[indexOfMaxSum[0], indexOfMaxSum[1] + i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[indexOfMaxSum[0] + 1, indexOfMaxSum[1] + i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[indexOfMaxSum[0] + 2, indexOfMaxSum[1] + i] + " ");
            }
            Console.WriteLine();
        }
    }
}
