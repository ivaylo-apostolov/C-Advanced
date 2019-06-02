using System;
using System.Numerics;

namespace Lab
{
    class Program
    {
        //public delegate string Operate(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, Multiply));
        }

        public static string Calculator(int x, int y, Func<int, int, string> opr)
        {
            return opr(x, y);
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string Multiply(int x, int y)
        {
            return (x * y).ToString();
        }
    }
}
