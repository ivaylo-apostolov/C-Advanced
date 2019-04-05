using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //key => hash function 

            //19:25-30 Обяснение на подреждане

            var list = new Dictionary<string, char>();

            list.Add("Niki", 'N');
            list.Add("Pesho", 'S');
            list.Add("Gosho", 'P');
            list.Add("Ivo", 'Q');

            list["Ivo"] = 'I';
            list.Remove("Gosho");


            if (list.ContainsKey("Pesho"))
            {
                Console.WriteLine(list["Pesho"]);
            }
            Console.WriteLine(string.Join(" ", list));

            foreach (var item in list)
            {
                Console.Write(item.Key + " ");
            }
            Console.WriteLine();

            //20:00
            var list2 = new Dictionary<string, List<int>>();

            list2.Add("Niki", new List<int>());

            list2["Niki"].Add(1);
            list2["Niki"].Add(2);
            list2["Niki"].Add(3);
            list2["Niki"].Add(4);

            //list2.Values.
            foreach (var item in list2)
            {
                Console.WriteLine($"{item.Keys} => {string.Join(", ", item.Values)}");
            }
            

            var number = Convert.ToInt32("123");
            var number2 = Convert.ToInt32(true);

            //Where(Подава се друг метод)

            double max = new int[] { 1, 2, 3, 4, 5 }.Average();

            var ar = new int[] { 1, 2, 3, 4 };


        }
    }
}
