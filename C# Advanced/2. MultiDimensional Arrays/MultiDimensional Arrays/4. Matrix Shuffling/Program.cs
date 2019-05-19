using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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
                var inputRow = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            string input = string.Empty;

            while((input = Console.ReadLine()).ToLower() != "end")
            {
                var arr = input
                    .Split()
                    .ToArray();

                var command = arr[0];

                if (command == "swap" && int.TryParse(arr[1], out int result) && result < matrix.GetLength(0)
                    && int.TryParse(arr[2], out int result2) && result2 < matrix.GetLength(1)
                    && int.TryParse(arr[3], out int result3) && result3 < matrix.GetLength(0)
                    && int.TryParse(arr[1], out int result4) && result4 < matrix.GetLength(1)
                    && arr.Length == 5)
                {
                    string temp = matrix[int.Parse(arr[1]), int.Parse(arr[2])];
                    matrix[int.Parse(arr[1]), int.Parse(arr[2])] = matrix[int.Parse(arr[3]), int.Parse(arr[4])];
                    matrix[int.Parse(arr[3]), int.Parse(arr[4])] = temp;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
