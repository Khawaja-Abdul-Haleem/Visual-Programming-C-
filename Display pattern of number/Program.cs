using System;

namespace Display_n_number_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

           
                Console.Write("Enter a number: ");

                num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int k = (i - 1); k >= 1; k--)
                    {

                        Console.Write(k);
                    }

                    Console.WriteLine(); // for next line
       
            }
            Console.ReadKey();
        }
    }
}
