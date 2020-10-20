using System;

namespace copy_array_to_other
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int n;

            Console.WriteLine("Test Data:");

            Console.Write("Input the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array: ", n);

            //input
            for (int i = 0; i < n; i++) {
                Console.Write("element - {0}: ", i);
                arr1[i] = int.Parse(Console.ReadLine());

            }

            //Store
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];

            }


            // output

            Console.WriteLine("\n\nThe elements stored in the first array are: ");

            for (int i = 0; i < n; i++) {
                Console.Write(" " + arr1[i]);
            }

            Console.WriteLine("\nThe elements copied into second array are: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + arr2[i]);
            }

            Console.ReadKey();
        }
    }
}
