using System;

namespace Check_Leap_Yeay
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("\t\t...Check LEAP YEAR....\n");
            Console.Write("......................................\n");
            Console.Write("Enter Year: ");
            //year = Convert.ToInt32(Console.ReadLine());
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.Write("\nIt's a Leap YEAR");
                Console.ReadKey();
            }

            else if (year % 100 == 0)
            {
                Console.Write("\nIt's a Leap YEAR");
                Console.ReadKey();
            }

            else if (year % 400 == 0)
            {
                Console.Write("\nIt's a Leap YEAR");
                Console.ReadKey();
            }

            else {
                Console.Write("\nIt's not a Leap YEAR");
                Console.ReadKey();
            }
        }
    }
}
