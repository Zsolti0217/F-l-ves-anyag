using System;

namespace Ponthatárok
{
    class Program
    {
        static void Main(string[] args)
        {
          int pontszam;


           Console.WriteLine("Adja meg a pontszámát: ");
            pontszam =int.Parse(Console.ReadLine());
            
            if pontszam((pontszam>=0) && (pontszam < 50))
                Console.WriteLine("Elégtelen");

            else if ((pontszam >=50) && (pontszam <65))
                Console.WriteLine("Elégséges");

            
            else if ((pontszam >=65) && (pontszam <80))
                Console.WriteLine("Elégséges");

            
            else if ((pontszam >=80) && (pontszam <90))
                Console.WriteLine("Elégséges");

            
            else if ((pontszam >=90) && (pontszam <100))
                Console.WriteLine("Elégséges");

            
            else if ((pontszam >=100) && (pontszam <0))
                Console.WriteLine("Érvénytelen");
        }
    }
}
