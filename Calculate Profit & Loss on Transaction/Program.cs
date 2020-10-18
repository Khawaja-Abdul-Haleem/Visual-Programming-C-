using System;

namespace Profit_loss
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost_price, sell_price, result = 0;

            Console.Write("Enter Cost Price: ");
            cost_price = int.Parse(Console.ReadLine());

            Console.Write("Enter Sell Price: ");
            sell_price = int.Parse(Console.ReadLine());

            if (cost_price > sell_price)
            {
                result = cost_price - sell_price;
                Console.Write("\nYou Got A loss of Amount: " + result);

            }

            else if (sell_price > cost_price) {
                result = sell_price - cost_price;
                Console.Write("\n You can Booked your proit amount: " + result);
            }

            else
            {
                Console.Write("\n You are running in No Profit & No Loss Condition..");
            }

            Console.ReadKey();
        }
    }
}
