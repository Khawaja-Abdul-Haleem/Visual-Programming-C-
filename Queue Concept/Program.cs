using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> my_queue= new Queue<string>();
            my_queue.Enqueue("Queue_1");
            my_queue.Enqueue("Queue_2");
            my_queue.Enqueue("Queue_3");
            
            //my_queue.Dequeue();
            //my_queue.Count();
            //my_queue.Contains("Queue_1");
            string top = my_queue.Peek();

            int count = my_queue.Count();
            Console.WriteLine("Count: " + count);

            Console.WriteLine("TOP: " + top);
            Console.WriteLine("Conatins Queue_1: " + my_queue.Contains("Queue_1"));
            Console.WriteLine(my_queue.Dequeue());
            Console.WriteLine(my_queue.Dequeue());

            int count1 = my_queue.Count();
            Console.WriteLine("Count: " + count1);

            top = my_queue.Peek();

            Console.WriteLine("TOP: " + top);
            Console.ReadKey();
        }
    }
}
