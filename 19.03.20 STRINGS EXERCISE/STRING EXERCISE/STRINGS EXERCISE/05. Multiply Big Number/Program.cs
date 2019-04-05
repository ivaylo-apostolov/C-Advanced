using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            BigInteger result = num1 * num2;
            Console.WriteLine(result);
        }
    }
}
