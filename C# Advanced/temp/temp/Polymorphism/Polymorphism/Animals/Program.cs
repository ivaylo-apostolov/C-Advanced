using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Gosho", "Wiskas");
            Console.WriteLine(cat.ExplainSelf());

            Dog dog = new Dog("Balkan", "Pedigrie");
            Console.WriteLine(dog.ExplainSelf());

            IMammal dog2 = new Animal("Street", "Bones");
            Console.WriteLine(dog2.Wallking());

            Console.WriteLine();
            Console.WriteLine();

            IMammal kuche = new Dog("Sashko", "Meat");
            Console.WriteLine(kuche.Wallking());
        }
    }
}
