using System;
using System.IO;

namespace FilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "TestFolder";

            string[] files = Directory.GetFiles(path);

            double totalSize = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }

            totalSize /= 1024 / 1024;

            Console.WriteLine(totalSize);
        }
    }
}
