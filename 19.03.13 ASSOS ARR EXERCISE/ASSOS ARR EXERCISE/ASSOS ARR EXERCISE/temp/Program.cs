using System;
using System.Collections.Generic;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Декларираш и инициализираш речника и само декларираш листа
            var dict = new Dictionary<string, List<int>>();

            // Задаваш key и инициализираш листа
            dict["Ivo"] = new List<int>(); 

            //Пълниш листа
            dict["Ivo"].Add(34);
            dict["Ivo"].Add(35);
            dict["Ivo"].Add(36);
            

        }
    }
}
