using System;

namespace User_Defined_Function
{
    class Program
    {
        public static void welcome(String name) {
            Console.Write("Welcome " + name + "!\n");
        }

        public static void greeting() {
            Console.Write("Have a Nice Day!");
        }
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter a Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            welcome(name);
            greeting();

            Console.ReadKey();
        }
    }
}
