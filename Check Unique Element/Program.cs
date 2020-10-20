using System;

namespace Check_Unique_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100]; ;
            int i, j, k, size, isUnique;

            //Reads size of the array
            Console.WriteLine("Test Data: ");

            Console.Write("Input the number of elements to be stored in the array: ");
            size = int.Parse(Console.ReadLine());
           
            //Reads elements in array
            Console.WriteLine("\nInput {0} elements in the array: ",size);
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Removing all duplicate elements from the array

            for (i = 0; i < size; i++)
            {
                // Assuming  cuurent element is unique */
                isUnique = 1;

                for (j = i + 1; j < size; j++)
                {

                    //If any duplicate element is found

                    if (arr[i] == arr[j])
                    {
                        // Removing duplicate element
                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        size--;
                        j--;
                        isUnique = 0;
                    }
                }

                /*
            If array element is not unique
            then also remove the current element
             */
                if (isUnique != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

            //Printing all unique elements in array
            Console.Write("\nThe unique elements found in the array are: ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
