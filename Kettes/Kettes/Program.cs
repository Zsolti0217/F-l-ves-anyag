using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kettes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10-es számrendszerbeli szám: ");
            int a = int.Parse(Console.ReadLine());
            List<int> binaris_szam = new List<int>();

            while(a != 0)
            {
                if (a % 2 == 0)
                {
                    a = a / 2;
                    binaris_szam.Add(0);
                }
                else
                {
                    a = (a - 1) / 2;
                    binaris_szam.Add(1);
                }

                Console.WriteLine("Binerális szám: ");
                for (int i = 0; i < binaris_szam.Count; i++)
                {
                    Console.Write
                    (binaris_szam[binaris_szam.Count - i - 1]);
                }

                Console.ReadLine();
            }
        }
    }
}
