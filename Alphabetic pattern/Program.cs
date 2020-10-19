using System;

namespace Display_Alphabetic_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            char alph = 'A';
            int n;
            int ctr = 1;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid using the alphabet:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of Letters (less than 26) in the Pyramid: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 0; j <= (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph++);
                }
                alph--;
                alph--;

                for (j = 0; j < (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph--);
                }
                ctr = ctr + 2;
                alph = 'A';
                Console.Write("\n");
                
            }
            Console.ReadKey();
        }
    }
}
