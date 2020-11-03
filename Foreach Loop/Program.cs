using System;

namespace Foreach_Loop_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < 5; i++) {
                Console.Write("Element " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\t\t| OUTPUT | ");
            foreach (int a in array) {
                Console.WriteLine(a);
            } // foreach loop end bracket

            Console.ReadKey();
        }
    }
}
