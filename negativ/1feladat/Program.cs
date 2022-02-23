using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _negativ
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekertszam1 = 0;
            int bekertszam2 = 0;

           
            string exit = "1";
            while (exit != "");
            {
                bekertszam1 = Convert.ToInt32(Console.ReadLine());
                bekertszam2 = Convert.ToInt32(Console.ReadLine());
                if (bekertszam1 > 0 && bekertszam2 > 0) 
                {
                    Console.WriteLine("Mindkét szám pozitiv");

                }
                else if (bekertszam1 < 0 && bekertszam2 < 0)
                {
                    Console.WriteLine("Mindkét bekért szám negativ");
                }

                else if (bekertszam1 > 0 && bekertszam2 < 0) 
                {
                    Console.WriteLine("A második bekért szám negatív");
                }


                else if (bekertszam1 < 0 && bekertszam2 > 0) 
                {
                    Console.WriteLine("Az első bekért szám negatív");
                }

                
            }

        }
    }
}
