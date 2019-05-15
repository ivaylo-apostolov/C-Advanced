using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthday = Console.ReadLine();

            IBirthable birthable = new Citizen(name, age, id, birthday);
            IIdentifiable identifiable = new Citizen(name, age, id, birthday);

            Console.WriteLine(birthable.Birthday);
            Console.WriteLine(identifiable.Id);
        }
    }
}
