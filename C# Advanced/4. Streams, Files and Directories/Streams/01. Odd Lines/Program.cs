using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string inputFile = "input.txt";
            string outputFile = "output.txt";
            string filePath = Path.Combine(path, inputFile);

            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();

                using (var writer = new StreamWriter(Path.Combine(path, outputFile)))
                {
                    int counter = 1;

                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine($"{counter}. {line}");
                            Console.WriteLine($"{counter}. {line}");
                            counter++;
                        }                        
                        
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
