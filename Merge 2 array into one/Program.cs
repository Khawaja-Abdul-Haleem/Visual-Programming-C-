using System;

namespace Merge_two_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] merge_arr = new int[200];
            int n1, n2, merge_n;
            int i, j, k;


            Console.Write("\n\nMerge two arrays of same size sorted in ascending order.\n");
            Console.Write("------------------------------------------------------------\n");

            Console.WriteLine("Test Data: ");
            Console.Write("Input the number of elements to be stored in the first array :");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n1);
            for (i = 0; i < n1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("\nInput the number of elements to be stored in the second array :");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n2);
            for (i = 0; i < n2; i++)
            {
                Console.Write("element - {0} : ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            /* size of merged array is size of first array and  size of second array */
            merge_n = n1 + n2;

            /*----------------- insert in the third array------------------------------------*/
            for (i = 0; i < n1; i++)
            {
                merge_arr[i] = arr1[i];
            }
            for (j = 0; j < n2; j++)
            {
                merge_arr[i] = arr2[j];
                i++;
            }
            /*----------------- sort the array in ascending order ---------------------------*/
            for (i = 0; i < merge_n; i++)
            {
                for (k = 0; k < merge_n - 1; k++)
                {

                    if (merge_arr[k] >= merge_arr[k + 1])
                    {
                        j = merge_arr[k + 1];
                        merge_arr[k + 1] = merge_arr[k];
                        merge_arr[k] = j;
                    }
                }
            }
            /*--------------- Prints the merged array ------------------------------------*/
            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < merge_n; i++)
            {
                Console.Write("{0} ", merge_arr[i]);
            }
          //  Console.Write("\n\n");
            Console.ReadKey();

        }
    }
}
