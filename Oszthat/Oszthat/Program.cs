﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oszthat
//    Írjon egy osztályt, a következő metódusokkal:
//setSzam: Számot olvas be a konzolról.Ellenőrzi, hogy a felhasználó csak számjegyet írjon be, egyébként hiba üzenetet ad.
//getSzam:  
//   - ha a beolvasott szám osztható 3-mal, akkor kiírja a konzolra: "három",
//   - ha a beolvasott szám osztható 5-tel, akkor kiírja a konzolra: "öt",
//   - egyébként kiírja a számot számjegyekkel.

//Végül a két metódusnak el kell készíteni a unit tesztjét.
{
    public class Met
    {
        string beker;
        int szam;
        int tovább = 1;
        public Met() { }
        public void setSzam()
        {
            while (this.tovább == 1)
            {
                Console.WriteLine("Írja be a számot");
                beker = Console.ReadLine();
                this.tovább = 0;
                if (beker.All(char.IsDigit))
                {
                    this.szam = Convert.ToInt32(beker);
                    Console.WriteLine("Csak számokattartalmaz.");
                }
                else
                {
                    this.tovább = 1;
                    Console.WriteLine("Az általad beírt adat nem csak számokattartalmazott.");
                }
            }
        }

        public void getSzam()
        {
            if (szam % 3 == 0 && szam % 5 == 0)
            {
                Console.WriteLine("Öttel és háromal oszható");
            }
            else if(szam % 5 == 0)
            {
                Console.WriteLine("Öt");
            }
            else
            {
                Console.WriteLine("Szám");
            }
        }


    }
    
}
