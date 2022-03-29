using System;

namespace hianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány hiányzás van?");
            int hianyzas = Convert.ToInt32(Console.ReadLine));

            if (hianyzas > 9)
            {
                Console.WriteLine("Add meg a születési dátumod: ");
                string szuleadat = Console.ReadLine();

                Console.WriteLine("Ekkor születet: {0}", szuleadat, "és ennyit hiányzot: {0}", hianyzas);
            }


            if ((9 < hianyzas) && (hianyzas < 16)) 
            {
                Console.WriteLine("Figyelmeztetés: ");

            }
            else if ((hianyzas > 15) && (hianyzas < 20))
            {
                Console.WriteLine("Osztályfönőki megrovás");
            }
            else if ((hianyzas > 18) && (hianyzas < 30))
            {
                Console.WriteLine("Igazgatói megrovás");
            }

            else
            {
                Console.WriteLine("megrovás");
            }

            Console.ReadKey();
        }
    }
}
