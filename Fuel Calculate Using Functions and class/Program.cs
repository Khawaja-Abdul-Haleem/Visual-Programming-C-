using System;

namespace Fuel_Calculate_using_class_and_function
{
    class Program
    {
        public class Flight {
            private int flightNo, distance, fuel;
            private string destination;

            public void CALFUEL() {
                if (distance <= 1800)
                {
                    fuel = 500;
                }

                else if (distance > 800 && distance <= 1800)
                {
                    fuel = 1500;
                }
                else
                    fuel = 3000;
            }
            public void SETDATA()
            {
                Console.Write("Enter Flight NO: ");
                flightNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Distance: ");
                distance= int.Parse(Console.ReadLine());

                Console.Write("Enter Destination: ");
                destination = Convert.ToString(Console.ReadLine());

                CALFUEL();
            }

            public void SHOWDATA() {
                Console.WriteLine();
                Console.Write("Flight No is: " + flightNo);
                Console.WriteLine("Destination is: " + destination);
                Console.WriteLine("Distance is: " + distance);
                Console.WriteLine("Fuel Amount is: " + fuel);
            }
        } 
        static void Main(string[] args)
        {
            Flight f = new Flight();
            f.SETDATA();
            f.SHOWDATA();

            Console.ReadKey();
        }
    }
}
