using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;

            Console.Write("Enter a number: ");
            a = float.Parse(Console.ReadLine());

            if (a < 0) // negative 
                Console.WriteLine("Less than 0");
            else if ((a >= 0) && (a <= 9)) // [0, 9] in interval notation
                Console.WriteLine("1 digit");
            else if ((a > 9) && (a <= 99)) // (9, 99] in interval notation
                Console.WriteLine("2 digits");
            else if ((a > 99) && (a <= 999)) // (99, 999] in interval notation
                Console.WriteLine("3 raghami");
            else if (a > 1000) // (1000, inf) in interval notation
                Console.WriteLine("More than 3 digits");

            Console.ReadKey();
        }
    }
}
