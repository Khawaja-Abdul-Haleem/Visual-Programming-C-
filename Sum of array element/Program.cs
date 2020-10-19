using System;

namespace SUM_of_array_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\n\nFind sum of all elements of array:\n");
            Console.Write("--------------------------------------\n");

            Console.Write("\nInput the number of elements to be stored in the array :");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("\nSum of all elements stored in the array is : {0}\n\n", sum);

            Console.ReadKey();
        }
    }
}
