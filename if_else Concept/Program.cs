using System;

// if percentage < 50,Show F Grade
// if percentage b/w 50-60, Show C grade
// if percentage b/w 60-70, Show B Grade
// if percentage > 70, Show A Grade

namespace If_else_concept
{
    class Program
    {
        static void Main(string[] args)
        {
            float obt_mark, total_mark, per;

            Console.Write("Enter Total Marks: ");
            total_mark = float.Parse(Console.ReadLine());

            Console.Write("Enter M arks Obtained: ");
            obt_mark = float.Parse(Console.ReadLine());

            per = (obt_mark / total_mark) * 100;
            Console.WriteLine("Percentage: " + per + " %");

            if (per > 70)
            {
                Console.WriteLine("Congratulations ! Your Grade is A");

            }

            else if (per >= 60 && per <= 70)
            {
                Console.WriteLine("Your Grade is B");
            }

            else if (per >= 50 && per <= 60)
            {
                Console.WriteLine("Your Grade is C");
            }

            else {
                Console.WriteLine("Unfotunately ! Your Grade is F");
            }

            Console.ReadKey();
        }
    }
}
