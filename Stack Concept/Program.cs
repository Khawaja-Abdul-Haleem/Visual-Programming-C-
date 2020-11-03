using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Book = new Stack<string>();
            Book.Push("BOOK 1");
            Book.Push("BOOk 2");

            string top = Book.Peek();

            int count = Book.Count();
            Console.WriteLine("Count: " + count);

            Console.WriteLine("TOP: " + top);
            Console.WriteLine(Book.Pop());
            Console.WriteLine(Book.Pop());

            int count1 =  Book.Count();
            Console.WriteLine("Count: " + count1);

            top = Book.Peek();

            Console.WriteLine("TOP: " + top);
            // Console.WriteLine("")
            Console.ReadKey();
        }
    }
}
