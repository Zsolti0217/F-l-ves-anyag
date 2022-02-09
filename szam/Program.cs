using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szam
{
    class Program
    {
        static void Main(string[] args)

        {
            int alsohatar = 1;
            int  felsohatar = 100;
                int probal = 5;
                int gondoltSzam;
                int tipp;
                   
              Random rnd = new Random();

            do
            {
                Console.WriteLine("Leszel az aki gondol a számra? (i/n)");
                if (Console.ReadKey().KeyChar == 'i') ;
                {
                    gondoltSzam = rnd.Next(felsohatar, alsohatar);
                    for (int i = 0; i =< probal) ;
                }
                
                Console.WriteLine("Folytatjuk a játékot? (i/n)");
            } while (Console.ReadKey().KeyChar == 'i');
            Console.ReadKey();

        }
    }
}
