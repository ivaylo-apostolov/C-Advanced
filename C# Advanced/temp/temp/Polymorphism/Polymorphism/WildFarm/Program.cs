using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int counter = 0;
            var listAnimals = new Stack<Animal>();
            var listFood = new Stack<Food>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (counter % 2 == 0)
                {
                    var tokens = input
                    .Split()
                    .ToArray();

                    string animalType = tokens[0];
                    string animalName = tokens[1];
                    double animalWeight = double.Parse(tokens[2]);

                    if (animalType == "Owl")
                    {
                        double wingSize = double.Parse(tokens[3]);
                        Owl owl = new Owl(animalName, animalWeight, wingSize);
                        owl.Sound();
                        listAnimals.Push(owl);
                    }
                    else if (animalType == "Hen")
                    {
                        double wingSize = double.Parse(tokens[3]);
                        Hen hen = new Hen(animalName, animalWeight, wingSize);
                        hen.Sound();
                        listAnimals.Push(hen);
                    }
                    else if (animalType == "Mouse")
                    {
                        string livingRegion = tokens[3];
                        Mouse mouse = new Mouse(animalName, animalWeight, livingRegion);
                        mouse.Sound();
                        listAnimals.Push(mouse);
                    }
                    else if (animalType == "Dog")
                    {
                        string livingRegion = tokens[3];
                        Dog dog = new Dog(animalName, animalWeight, livingRegion);
                        dog.Sound();
                        listAnimals.Push(dog);
                    }
                    else if (animalType == "Cat")
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];
                        Cat cat = new Cat(animalName, animalWeight, livingRegion, breed);
                        cat.Sound();
                        listAnimals.Push(cat);
                    }
                    else if (animalType == "Tiger")
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];
                        Tiger tiger = new Tiger(animalName, animalWeight, livingRegion, breed);
                        tiger.Sound();
                        listAnimals.Push(tiger);
                    }
                }
                else if (counter % 2 != 0)
                {
                    var token = input
                        .Split()
                        .ToArray();

                    string foodType = token[0];
                    int quantity = int.Parse(token[1]);

                    if (foodType == "Vegetable")
                    {
                        Vegetable vegetable = new Vegetable(quantity);
                        listFood.Push(vegetable);
                    }
                    else if (foodType == "Fruit")
                    {
                        Fruit fruit = new Fruit(quantity);
                        listFood.Push(fruit);
                    }
                    else if (foodType == "Meat")
                    {
                        Meat meat = new Meat(quantity);
                        listFood.Push(meat);
                    }
                    else if (foodType == "Seeds")
                    {
                        Seeds seeds = new Seeds(quantity);
                        listFood.Push(seeds);
                    }
                }

                if (counter % 2 != 0)
                {
                    listAnimals.Peek().Eat(listFood.Peek());
                }

                counter++;
            }

            while (listAnimals.Count > 0)
            {
                Console.WriteLine(listAnimals.Pop().ToString());
            }
        }
    }
}
