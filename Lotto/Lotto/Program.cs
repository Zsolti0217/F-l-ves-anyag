using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[5];
            int db = 0;
            while(db!= 5)
            {
                bool egyezike = false;
                int veletlenszam = rnd.Next(1, 91);
                for(int i = 0; i <db; i++)
                {
                    if (tomb[i] == veletlenszam) egyezike = true; ;
                }

                if (egyezike!)
                {
                    tomb[db] = veletlenszam; db++;
                }

                Console.WriteLine("Lottó számok: ");
                for (int i = 0; i < db; i++)
                {
                    Console.Write("{0}, ", tomb[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
