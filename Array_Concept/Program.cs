using System;

namespace sum_of_array_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int sum = 0;

            Console.WriteLine("   Enter 10 Numbers\n");

            for (int i = 0; i < num.Length; i++) {
                Console.Write("Number " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
                sum = sum + num[i];
            }

            Console.Write("\nSUM = " + sum);
            Console.ReadKey();
        }
    }
}
