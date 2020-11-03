using System;

namespace Generic_Function
{
    class Program
    {
        static void Compare <T> (T a, T b) {
            if (a.Equals(b))
                Console.WriteLine("Equals");
            else
                Console.WriteLine("Not Equals");
        }
        static void Main(string[] args)
        {
            int x = 21, y = 21;
            string s1 = "Hello", s2 = "World";

            Compare<int>(x, y);
            Compare<string>(s1, s2);

            Console.ReadKey();
        }
    }
}
