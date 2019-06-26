using System;
using System.Linq;

namespace Helen_s_abdiction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string firstLine = Console.ReadLine();

            char[,] matrix = new char[n, firstLine.Length - 1];

            for (int row = 0; row < n; row++)
            {
                if (row != 0)
                {
                    firstLine = Console.ReadLine();
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = firstLine[col];
                }
            }

            int parisR = -1;
            int parisC = -1;
            int helenR = -1;
            int helenC = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        parisR = row;
                        parisC = col;
                    }
                    if (matrix[row, col] == 'H')
                    {
                        helenR = row;
                        helenC = col;
                    }
                }
            }

            bool isDead = false;
            bool isReachHelen = false;

            while (!isDead && !isReachHelen)
            {
                var token = Console.ReadLine()
                    .Split()
                    .ToArray();

                string move = token[0];
                int spartanR = int.Parse(token[1]);
                int spartanC = int.Parse(token[2]);

                energy -= 1;

                if (energy <= 0)
                {
                    isDead = true;
                }

                matrix[spartanR, spartanC] = 'S';

                if (move == "up")
                {
                    if (parisR - 1 < 0)
                    {

                    }
                }
            }



        }
    }
}
