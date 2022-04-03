using System;

namespace Pont_tavolsag
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());

            double tav = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((b2 - a2), 2));
            Console.WriteLine("Tavolsag {0}", tav);

            Console.ReadKey();
        }

    }
}
