using System;

namespace Check_Vowel_or_consonent
{
    class Program
    {
        static void Main(string[] args)
        {
            char alpha;

            Console.Write("Enter Alphabet: ");
            alpha = Convert.ToChar(Console.ReadLine());

            if (alpha == 'a' || alpha == 'A' || alpha == 'e' || alpha == 'E' || alpha == 'i' || alpha == 'I' || alpha == 'o' || alpha == 'O' || alpha == 'u' || alpha == 'U') {
                Console.Write("\nThe Character is Vowel");
            }

            else
            {
                Console.Write("\n The Character is Consonent");
            }

            Console.ReadKey();
        }
    }
}
