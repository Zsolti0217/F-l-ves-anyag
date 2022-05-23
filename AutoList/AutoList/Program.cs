using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoList
{
    internal class AutoLista
    {
        private class Auto
        {
            private string rendszam;
            private string tipus;
            private int gyartasiev;
            private DateTime muszaki;
            private string gyartmany;
            private string tulajdonos;

            public Auto() { }
            public Auto(string rendszam, string tipus, int gyartasiev, DateTime muszaki, string gyartmany, string tulajdonos)
            {
                this.rendszam = rendszam;
                this.tipus = tipus;
                this.gyartasiev = gyartasiev;
                this.muszaki = muszaki;
                this.gyartmany = gyartmany;
                this.tulajdonos = tulajdonos;
            }
            public void printAuto()
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", rendszam, gyartmany, tipus, gyartasiev, muszaki.ToShortDateString(), tulajdonos);
            }

            private List<Auto> autoLista;
            private string fajlNev;
            public AutoLista()
            {
                autoLista = new List<Auto>();
            }
            public void Beolvas()
            {
                string sor;
                string[] mezok;
                Console.WriteLine("Adja meg a szövegfájl nevét és elérési útvonalát!");
                fajlNev = Console.ReadLine();
                if (!fajlNev.EndsWith(".txt")) fajlNev += ".txt";
                using (StreamReader sr = new StreamReader(fajlNev, Encoding.Default))
                    while (sr.EndOfStream == false)
                    {
                        sor = sr.ReadLine();
                        if (sor.Trim().Length == 0) continue;
                        mezok = sor.Split(',');
                        autoLista.Add(new Auto(mezok[0], mezok[1], mezok[2], DateTime.Parse(mezok[3]), DateTime.Parse(mezok[4]), mezok[5]));
                    }
            }
            public void kiir()
            {
                foreach (Auto a in autoLista)
                {
                    a.printAuto();
                }
                Console.ReadKey();




            }

        }
        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
