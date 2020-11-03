using System;

namespace swap_using_generic_function
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b) {
            T c;
            c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 6;
            string s1 = "Hellow", s2 = "World";

            Console.WriteLine("\t\t______________________________________\n");
            Console.WriteLine("\t\t\t\t INPUT");
            Console.WriteLine("\t\t______________________________________\n");


            Console.WriteLine("Before Swap int: \n x = {0}, y = {1} ", x, y);
            Console.WriteLine("Before Swap string: \n s1 = {0}, s2 = {1} ", s1, s2);
            
            Swap<int>(ref x, ref y);
            Swap<string>(ref s1, ref s2);

            Console.WriteLine("\t\t______________________________________\n");
            Console.WriteLine("\t\t\t\t OUTPUT");
            Console.WriteLine("\t\t______________________________________\n");

            Console.WriteLine("After Swap int: \n x = {0}, y = {1} ", x, y);
            Console.WriteLine("After Swap string: \n s1 = {0}, s2 = {1} ", s1, s2);

            Console.ReadKey();
        }
    }
}
