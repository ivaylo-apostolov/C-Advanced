using System;
using System.Collections.Generic;

namespace AbsAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Balkan");
            var dog2 = AnimalFactory.Create("Bella");
            var horse2 = AnimalFactory.Create("Tosho");

            Console.WriteLine(dog.Sleeping());
            Console.WriteLine(dog.Hunting());

            var cat = new Cat();

            Console.WriteLine(cat.Eat());
            Console.WriteLine(cat.Sleep());

            var list = new List<Animal>();

            list.Add(dog);
            list.Add(new Horse("Storm"));
            list.Add(new Snake("Sussy"));

            foreach (Animal animal in list)
            {
                Console.WriteLine(animal.Sleeping());
            }
        }
    }
}
