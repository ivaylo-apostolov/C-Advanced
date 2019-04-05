using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .ToArray();

            string str1 = arr[0];
            string str2 = arr[1];

            int result = Add(str1, str2);

            Console.WriteLine(result);
        }

        private static int Add(string str1, string str2)
        {
            int max = Math.Max(str1.Length, str2.Length);
            int min = Math.Min(str1.Length, str2.Length);
            int result = 0;

            
            for (int i = 0; i < min; i++)
            {
                result += str1[i] * str2[i];
            }
            if (str1.Length != str2.Length)
            {
                if (str1.Length > str2.Length)
                {
                    for (int i = str2.Length; i < str1.Length; i++)
                    {
                        result += str1[i];
                    }
                }
                else if (str1.Length < str2.Length)
                {
                    for (int i = str1.Length; i < str2.Length; i++)
                    {
                        result += str2[i];
                    }
                }
            }
            return result;
        }
    }
}
