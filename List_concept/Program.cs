using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> new_list= new List<string>();
            new_list.Add("Ahmed");
            new_list.Add("Qasim");
            new_list.Add("Khalid");
            new_list.Add("Usaama");
            new_list.Add("Faisal");
            new_list.Add("Uzair");

            foreach (string items in new_list)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("\n_______________________________________________\n");
            bool find = new_list.Contains("Khalid");
            Console.WriteLine("Find Khalid: " + find);

            double total = new_list.Count();
            Console.WriteLine("Total: " + total);

            string element = new_list.ElementAt(2);
            Console.WriteLine("ELEMENT AT 2 INDEX: " + element);

            Console.WriteLine("Remove Khalid: " + new_list.Remove("Khalid"));
            new_list.RemoveAt(0);
            Console.WriteLine("Removed item at index 0");

            Console.WriteLine("Reverse List");
            new_list.Reverse();

            Console.WriteLine();
            foreach (string items in new_list)
            {
                Console.WriteLine(items);
            }

            Console.ReadKey();
        }
    }
}
