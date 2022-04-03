using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaris
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            Console.WriteLine("Adjon meg binerális szémot: ");
            string szam = Console.ReadLine();
            for (int i = 0; i < szam.Length; i++)
            {
                if (Convert.ToString(szam[i]) == "1") db++;
                
            }
            Console.WriteLine("Megadott binerális szám {0} darab egyes szerepelt.", db);
            Console.ReadLine();
        }
    }
}
