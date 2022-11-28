using System;

namespace NumChecker01
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;

            Console.Write("Adad ra vared konid: ");
            a = float.Parse(Console.ReadLine());

            if (a < 0) // manfi boodano check mikone, age zire 0 bashe.
                Console.WriteLine("manfi");
            else if ((a >= 0) && (a <= 9)) // Inja age 1 raghami bood ro check mikone, ke az 0 ta 9 hastesh.
                Console.WriteLine("1 raghami");
            else if ((a > 9) && (a <= 99)) // inja 2 raghami boodan ro check mikone, ke az 10 ta 99 hastesh.
                Console.WriteLine("2 raghami");
            else if ((a > 99) && (a <= 999)) // Inja age adad 3 raghami bood ro check mikone, ke az 100 to 999 hastesh.
                Console.WriteLine("3 raghami");
            else if (a > 1000) // Bish az 3 ragham bashe ro check mikone, ke bish az 1000 hastesh.
                Console.WriteLine("bish az 3 ragham");

            Console.ReadKey();
        }
    }
}
