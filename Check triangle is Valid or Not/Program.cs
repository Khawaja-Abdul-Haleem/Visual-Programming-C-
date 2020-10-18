using System;

namespace Check_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, sum = 0;

            Console.Write("Enter X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter Y: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter Z: ");
            z = int.Parse(Console.ReadLine());

            sum = x + y + z;

            if (sum == 180)
            {

                Console.Write("Triangle is Valid");
            }
            else
            {
                Console.Write("Triangle is not Valid");
            }

            Console.ReadKey();
        }
    }
}
