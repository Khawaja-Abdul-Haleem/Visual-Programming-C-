﻿using System;

namespace Count_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, count;


            Console.Write("\n\nCount the frequency of each element of an array:\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = count;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }
            Console.ReadKey();
        }
    }
}