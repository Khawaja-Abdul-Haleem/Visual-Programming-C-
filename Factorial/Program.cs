using System;

namespace factorial_using_function
{
    class Program
    {
        static decimal Factorial(int n1)
        {
            // The bottom of the recursion
            if (n1 == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n1 * Factorial(n1 - 1);
            }
        }
        static void Main(string[] args)
        {
            decimal f;
            Console.Write("\n\nRecursive Function : To find the factorial of a given number :\n");
            Console.Write("------------------------------------------------------------------\n");
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            f = Factorial(num);
            Console.WriteLine("The factorial of {0}! is  {1}", num, f);
            Console.ReadKey();
        }
    }
}
