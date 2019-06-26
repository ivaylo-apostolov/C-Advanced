using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string inputRows = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = inputRows[col];
                }
            }

            int sRow = -1;
            int sCol = -1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        sRow = row;
                        sCol = col;
                    }
                }
            }

            bool isBH = false;
            int bh1Row = -1;
            int bh1Col = -1;

            int bh2Row = -1;
            int bh2Col = -1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'O' && isBH == false)
                    {
                        bh1Row = row;
                        bh1Col = col;
                        isBH = true;
                    }

                    if (matrix[row, col] == 'O' && isBH)
                    {
                        bh2Row = row;
                        bh2Col = col;
                    }
                }
                
            }

            int energy = 0;
            bool isDead = false;

            while (true)
            {
                string move = Console.ReadLine();

                if (move == "up")
                {
                    if (sRow - 1 < 0)
                    {
                        isDead = true;
                        matrix[sRow, sCol] = '-';
                        break;
                    }

                    matrix[sRow, sCol] = '-';
                    sRow -= 1;

                    if (char.IsDigit(matrix[sRow, sCol]))
                    {
                        energy += int.Parse(matrix[sRow, sCol].ToString());
                        matrix[sRow, sCol] = 'S';                        
                    }
                    else if (matrix[sRow, sCol] == '-')
                    {
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == 'O')
                    {
                        if (sRow == bh1Row && sCol == bh1Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh2Row;
                            sCol = bh2Col;
                            matrix[sRow, sCol] = 'S';
                        }
                        else if (sRow == bh2Row && sCol == bh2Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh1Row;
                            sCol = bh1Col;
                            matrix[sRow, sCol] = 'S';
                        }
                    }
                }
                else if (move == "down")
                {
                    if (sRow + 1 == n)
                    {
                        isDead = true;
                        matrix[sRow, sCol] = '-';
                        break;
                    }

                    matrix[sRow, sCol] = '-';
                    sRow += 1;

                    if (char.IsDigit(matrix[sRow, sCol]))
                    {
                        energy += int.Parse(matrix[sRow, sCol].ToString());
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == '-')
                    {
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == 'O')
                    {
                        if (sRow == bh1Row && sCol == bh1Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh2Row;
                            sCol = bh2Col;
                            matrix[sRow, sCol] = 'S';
                        }
                        else if (sRow == bh2Row && sCol == bh2Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh1Row;
                            sCol = bh1Col;
                            matrix[sRow, sCol] = 'S';
                        }
                    }
                }
                else if (move == "left")
                {
                    if (sCol - 1 < 0)
                    {
                        isDead = true;
                        matrix[sRow, sCol] = '-';
                        break;
                    }

                    matrix[sRow, sCol] = '-';
                    sCol -= 1;

                    if (char.IsDigit(matrix[sRow, sCol]))
                    {
                        energy += int.Parse(matrix[sRow, sCol].ToString());
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == '-')
                    {
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == 'O')
                    {
                        if (sRow == bh1Row && sCol == bh1Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh2Row;
                            sCol = bh2Col;
                            matrix[sRow, sCol] = 'S';
                        }
                        else if (sRow == bh2Row && sCol == bh2Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh1Row;
                            sCol = bh1Col;
                            matrix[sRow, sCol] = 'S';
                        }
                    }
                }
                else if (move == "right")
                {
                    if (sCol + 1 == n)
                    {
                        isDead = true;
                        matrix[sRow, sCol] = '-';
                        break;
                    }

                    matrix[sRow, sCol] = '-';
                    sCol += 1;

                    if (char.IsDigit(matrix[sRow, sCol]))
                    {
                        energy += int.Parse(matrix[sRow, sCol].ToString());
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == '-')
                    {
                        matrix[sRow, sCol] = 'S';
                    }
                    else if (matrix[sRow, sCol] == 'O')
                    {
                        if (sRow == bh1Row && sCol == bh1Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh2Row;
                            sCol = bh2Col;
                            matrix[sRow, sCol] = 'S';
                        }
                        else if (sRow == bh2Row && sCol == bh2Col)
                        {
                            matrix[sRow, sCol] = '-';
                            sRow = bh1Row;
                            sCol = bh1Col;
                            matrix[sRow, sCol] = 'S';
                        }
                    }
                }

                if (energy >= 50)
                {
                    break;
                }

            }

            if (energy >= 50)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else if (isDead)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {energy}");

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
