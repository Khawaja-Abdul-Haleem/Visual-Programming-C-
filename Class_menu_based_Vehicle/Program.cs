using System;

namespace Class_using_menu_based_funstions
{
    class Program
    {
        public static int totalAmount = 0, Cat1Vehicals = 0, Cat2Vehicals = 0, nonPaid = 0;

        public static void cat_1() {
            totalAmount += 30;
            Cat1Vehicals += 1;
            Console.Write("\nVehicle Crossed (Cat_1)...\n");
        }

        public static void cat_2()
        {
            totalAmount += 50;
            Cat2Vehicals += 1;
            Console.Write("\nVehicle Crossed (Cat_2)...\n");
        }

        public static void non_paid_vehicle() {
            nonPaid += 1;
            Console.Write("\nVehicle Crossed (Non_paid)...\n");
        }

        public static void  total_collection_amt() {
            Console.Write("\nTotal Collection Amount: " + totalAmount + "\n");
        }

        public static void total_vehicle_crossed() {
            Console.Write("\nTotal Vehicle Crossed: " + (nonPaid + Cat1Vehicals + Cat2Vehicals) + "\n");
        }

        public static void total_paid_vehicle() {
            Console.Write("\nPaid Vehicle Crossed: " + (Cat1Vehicals + Cat2Vehicals) + "\n");
        }

        public static void total_unpaid_vehicle() {
            Console.Write("\nTotal Unpaid Vehicle Crossed: " + nonPaid + "\n");
        }

        public static void Clear_screen() {
            Console.Clear();
            Console.Write("\nScreen Cleared...\n");
        }
        public static void menu()
        {
            Console.WriteLine("\n\t\t\t Main Menu \n");
            Console.WriteLine("\t\tpress 1 paying vehical (LTV) cat-1 ");
            Console.WriteLine("\t\tpress 2 paying vehical(HTV) cat-2 ");
            Console.WriteLine("\t\tpress 3 non payingvehical ");
            Console.WriteLine("\t\tpress 4 total collected amount");
            Console.WriteLine("\t\tpress 5 total number of vehical crossed ");
            Console.WriteLine("\t\tpress 6 total number of paid vehical crossed ");
            Console.WriteLine("\t\tpress 7 total number of unpaid vehical crossed ");
            Console.WriteLine("\t\tpress 8 Clear Screen ");
            Console.WriteLine("\t\tpress 9 Exit ");

            Console.Write("\nEnter Your Choice: ");

        }
        static void Main(string[] args)
        {

            int choice;
            do {
                menu();
                choice = int.Parse(Console.ReadLine());

                if (choice == 1) {
                    cat_1();
                } // choice 1 close bracket

                if (choice == 2)
                {
                    cat_2();
                } // choice 2 close bracket

                if (choice == 3)
                {
                    non_paid_vehicle();
                } // choice 3 close bracket

                if (choice == 4)
                {
                    total_collection_amt();
                } // choice 4 close bracket

                if (choice == 5)
                {
                    total_vehicle_crossed();
                } // choice 5 close bracket

                if (choice == 6)
                {
                    total_paid_vehicle();
                } // choice 6 close bracket

                if (choice == 7)
                {
                    total_unpaid_vehicle();
                } // choice 7 close bracket

                if (choice == 8)
                {
                    Clear_screen();
                } // choice 8 close bracket

            } while (choice != 9);

            Console.ReadKey();

        }
    }
}
