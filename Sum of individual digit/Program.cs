using System;

namespace sum_of_digits
{
    class Program
    {
        public static int SumCal(int n)
        {
            string n1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += int.Parse(n1.Substring(i, 1));
            return sum;
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.Write("--------------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));
            Console.ReadKey();
        }
    }
}
