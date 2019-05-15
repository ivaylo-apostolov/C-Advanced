using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5.5);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.CalculatePerimeter());
            Console.WriteLine(square.Draw());

            Console.WriteLine();

            var rectangle = new Rectangle(1.2, 5.5);
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
