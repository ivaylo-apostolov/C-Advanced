using System;
using System.Text;

namespace LAB_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "asdfg";
            text = text.Replace("asd", string.Empty);
            Console.WriteLine(text);

            string newString = new string('*', 5); //*****

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.AppendLine("John! ");
            sb.Append("I sent you an email.");
            string stringche = sb.ToString();
            Console.WriteLine(stringche);

        }
    }
}
