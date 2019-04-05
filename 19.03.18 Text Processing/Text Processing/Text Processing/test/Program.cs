using System;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            sb.Append("123");
            sb.Append("456");

            sb.Insert(3, "Ivo");
            sb.Replace("I", "P");

            Console.WriteLine(sb);
            

        }
    }
}
