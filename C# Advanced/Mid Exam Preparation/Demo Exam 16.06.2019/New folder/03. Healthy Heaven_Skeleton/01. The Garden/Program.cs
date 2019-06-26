using System;
using System.Linq;

namespace _01._The_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRows = int.Parse(Console.ReadLine());

            var matrix = new char[inputRows][];

            for (int row = 0; row < inputRows; row++)
            {
                var inputRow = Console.ReadLine()
                    .Split()
                    .ToArray();

                matrix[row] = new char[inputRow.Length - 1];

                for (int col = 0; col < matrix[row].Length; col++)
                {

                }
            }
        }
    }
}
