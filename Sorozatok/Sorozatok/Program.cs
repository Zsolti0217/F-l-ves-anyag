using System;

namespace Sorozatok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0} elem: ", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
            }
            int elso = tomb[0];
            int allando = tomb[1] - tomb[0];
            int hanyados = tomb[1] / tomb[0];

            bool szamtani = true;
            bool mertani = true;

            for(int a = 1; a < 4; a++)
            {
                if (elso + (a * allando) != tomb[a]) szamtani = false;
                if (tomb[a - 1] * hanyados != tomb[a]) mertani = false;
            }

            if (szamtani) Console.WriteLine("A sorozat számtani.");
            if (mertani) Console.WriteLine("A sorozat mértani.");

            Console.ReadLine();

        }
    }
}
