using System;

namespace CatAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Gosho", 5);
            var dog = new Dog("Balkan", 9);
            var puppy = new Puppy("Jony", 0);

            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.SayMeau());

            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.SayJaf());
            
            Console.WriteLine(puppy.Name + " " + puppy.Age);
            Console.WriteLine(puppy.Weed());
        }        
    }
}
