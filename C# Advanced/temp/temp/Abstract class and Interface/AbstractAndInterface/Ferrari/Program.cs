using System;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar driver = new Ferrari("George");

            Console.WriteLine(driver.ToString());
        }
    }
}
