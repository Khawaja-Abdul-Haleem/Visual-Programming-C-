using System;

namespace Display_total_BILL
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, unit;
            string name;
            double charges = 0, Total = 0, unit_charge = 0, per = 0;


            Console.Write("..........................................\n");
            Console.Write("\t\t\tInput\n");
            Console.Write("..........................................\n");

            Console.Write("Enter Customer ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Unit Consumed: ");
            unit = int.Parse(Console.ReadLine());

            if (unit <= 199)
            {
                unit_charge = 1.20;
                charges = unit * unit_charge;
            }

            else if (unit > 199 && unit < 400)
            {
                unit_charge = 1.50;
                charges = unit * unit_charge;
            }

            else if (unit >= 400 && unit < 600)
            {
                unit_charge = 1.80;
                charges = unit * unit_charge;
            }

            else if (unit >= 600) {
                unit_charge = 2.00;
                charges = unit * unit_charge;
            }

            per = (charges / 100) * 15;
            Total = per + charges;

            Console.Write("\n..........................................\n");
            Console.Write("\t\t\tOutput\n");
            Console.Write("..........................................\n");

            Console.Write(charges);

            Console.Write("Customer IDNO: " + id + '\n');
            Console.Write("Customer Name " + name + '\n');
            Console.Write("Unit Consumed: " + unit + '\n');
            Console.Write("Amount Charges @Rs. {0} per unit: {1} \n", unit_charge, charges);
            Console.Write("Surchage Amount: " + per + '\n');
            Console.Write("Net Amount Paid By the Customer: " + Total);

            Console.ReadKey();
        }
    }
}
