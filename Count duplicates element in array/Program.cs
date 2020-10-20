using System;

namespace Total_Number_of_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num, count = 0;

            //Reads size of the array
            Console.WriteLine("Test Data: ");

            Console.Write("Input the number of elements to be stored in the array: ");
            num = int.Parse(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("\nInput {0} elements in the array: ", num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("element - {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Find all duplicate elements in array
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nTotal number of duplicate elements found in array: " + count);
           
            Console.ReadKey();
        }
    }
}
