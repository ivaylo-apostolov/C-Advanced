using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());

            var list = new List<Person>();

            for (int i = 0; i < persons; i++)
            {
                var arr = Console.ReadLine()
                    .Split()
                    .ToArray();

                var person = new Person(arr[0], arr[1], int.Parse(arr[2]), double.Parse(arr[3]));
                list.Add(person);
            }

            list.OrderBy(f => f.FirstName)
                .ThenBy(a => a.Age)
                .ToList();

            int salaryIncrease = int.Parse(Console.ReadLine());

            foreach (var name in list)
            {
                name.SalaryIncrease(name, salaryIncrease);
            }

            foreach (var name in list)
            {

                Console.WriteLine(name.ToString());
            }
        }
    }
}
