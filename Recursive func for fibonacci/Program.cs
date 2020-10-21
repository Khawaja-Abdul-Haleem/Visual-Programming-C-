using System;

namespace Recursive_function_for_fibonacci
{
   
    class Program
    {
        public static int Fib(int n1)
        {
            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
        }
        static void Main(string[] args)
        {
            int num;

            Console.Write("\n\nRecursive Function : To calculate the Fibonacci number of a specific term :\n");
            Console.Write("-------------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
            Console.ReadKey();
        }
    }
}
