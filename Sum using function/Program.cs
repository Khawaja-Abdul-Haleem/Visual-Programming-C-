using System;

namespace Sum_of_2_numebr_user_defined_function
{
    class Program
    {
        public static int sum(int a, int b) {
            int total = 0;
            total = a + b;

            return total;
        }
        static void Main(string[] args)
        {
            int n1, n2, result;

            Console.Write("Enter 1st number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            n2 = int.Parse(Console.ReadLine());

            result = sum(n1, n2);

            Console.Write("The sum of two numbers is: " + result);
            Console.ReadKey();
        }
    }
}
