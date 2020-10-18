using System;

namespace Display_maximum_value_using_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int max = 0;

            Console.WriteLine("   Enter 10 numbers\n");

            for (int i = 0; i < arr.Length; i++) {
                Console.Write("Enter Number " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            max = arr[0];

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i];
                }
            }

            Console.WriteLine("\n MAX = " + max);
            Console.ReadKey();
        }
    }
}
