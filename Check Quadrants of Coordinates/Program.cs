using System;

namespace Check_Quadrant_of_Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("\n\n");
            Console.Write("Find the quadrant in which the coordinate point lies:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value for X coordinate :");
            x = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            y = int.Parse(Console.ReadLine());


            if (x > 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", x, y);
            else if (x < 0 && y > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", x, y);
            else if (x < 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", x, y);
            else if (x > 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", x, y);
            else if (x == 0 && y == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", x, y);

            Console.ReadKey();
        }
    }
}
