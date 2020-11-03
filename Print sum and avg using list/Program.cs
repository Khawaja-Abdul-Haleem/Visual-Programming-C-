using System;
using System.Collections.Generic;

namespace Calcuate_And_print_sum_using_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            int sum = 0;
            int avg = 0;

            while (true) {
                Console.Write("Enter Postive Integer: ");
                string limit = Console.ReadLine();

                if (limit == string.Empty)
                    break;
                if (int.Parse(limit) < 0)
                    Console.WriteLine("Invalid Number");
                else
                    sequence.Add(int.Parse(limit));

            }// while closing bracket

            if (sequence.Count == 0)
                Console.WriteLine("Cannot Calcuate");
            else {
                foreach (int item in sequence) {
                    sum += item; 
                }
            } // else closing bracket

            int total = sequence.Count;
            try
            {
                avg = sum / total;
            }
            catch {
                if (sum == 0 || total == 0 ) {
                    Console.WriteLine("Something is Wrong ... Retry");
                }
            }
            Console.WriteLine();
            Console.WriteLine("SUM: " + sum);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Average: " + avg);

            Console.ReadKey();

        }
    }
}
