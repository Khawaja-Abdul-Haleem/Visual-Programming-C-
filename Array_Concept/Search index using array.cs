using System;

namespace Search_Index_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int search_no;
            bool flag = false;

            Console.WriteLine("  Enter 10 numbers \n");

            for (int i = 0; i < num.Length; i++) {
                Console.Write("Number " + i + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter No. To Search: ");
            search_no = int.Parse(Console.ReadLine());

            for (int i = 0; i < num.Length; i++) {
                if (num[i] == search_no) {
                    Console.Write("\nFound At Index: " + i + "\n" );
                    flag = true;
                }
            } // for closing bracket

            if (flag == false) {
                Console.WriteLine("\nNot Found");
            }
            Console.ReadKey();

        }
    }
}
