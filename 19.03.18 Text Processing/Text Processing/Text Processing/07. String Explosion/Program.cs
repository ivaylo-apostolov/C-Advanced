using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(inputText);

            int booms = 0;
            bool explosion = false;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '>')
                {
                    explosion = true;
                    continue;
                }

                if (explosion)
                {
                    char ch = sb[i];
                    booms += int.Parse(ch.ToString());
                    explosion = false;
                }

                if (booms > 0 && sb[i] != '>')
                {
                    sb.Remove(i, 1);
                    booms--;
                    i--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
