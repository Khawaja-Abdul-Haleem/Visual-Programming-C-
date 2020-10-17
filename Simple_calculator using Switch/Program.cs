using System;

namespace Simple_Calculator__Using_Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_1, val_2, result, rem;
            char op;

            Console.Write("Enter 1st number: ");
            val_1 = float.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            val_2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op) {
                case '+':
                    result = val_1 + val_2;
                    Console.WriteLine("Sum ({1}+{2}) = {0}: " ,result, val_1, val_2);
                    break;

                case '-':
                    result = val_1 - val_2;
                    Console.WriteLine("Subtract ({1}-{2}) = {0}: ", result, val_1,val_2);
                    break;

                case '*':
                    result = val_1 * val_2;
                    Console.WriteLine("Multiplication ({1}*{2}) = {0}", result, val_1,val_2);
                    break;

                case '/':
                    if (val_2 == 0)
                        Console.WriteLine("Cannot be divided");
                    else
                    {
                        result = val_1 / val_2;
                        rem = val_1 % val_2;
                        Console.WriteLine("Division ({1}/{2}) = {0}", result, val_1, val_2);
                        Console.WriteLine("Reminder ({1}%{2}) = {0}", rem, val_1, val_2);
                    }
                    break;

                default:
                    Console.WriteLine("Wrong Operator !!");
                    break;
            } // switch statment closing bracket

            Console.ReadKey();
        }
    }
}
