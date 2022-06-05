using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaratLapoz
{
    class BaratLapoz
    {
        private string nev;
        private DateTime szuletes;
        private char nem;
        private int buli, tovabb = 0;
        private string sor;
        private string[] mezo;



        public BaratLapoz() { }

        public BaratLapoz(string nev, DateTime szuletes, char nem, int buli)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.nem = nem;
            this.buli = buli;
        }

        public void printBarat()
        {
            Console.WriteLine("{0,-20} {1,-10} {2,1} {3}", this.nev, this.szuletes.ToShortDateString(), this.nem, this.buli);
        }
        private List<BaratLapoz> baratLista = new List<BaratLapoz>();
        public void bekeres()
        {
            using (StreamReader sr = new StreamReader("baratlapoz.txt", Encoding.Default))
                while (sr.EndOfStream == false)
                {
                    sor = sr.ReadLine();
                    if (sor.Trim().Length == 0) continue;

                    mezo = sor.Split(',');

                    baratLista.Add(new BaratLapoz(
                        mezo[0],
                        DateTime.Parse(mezo[1]),
                        char.Parse(mezo[2]),
                        int.Parse(mezo[3])));
                }
        }
        public void kiir()
        {
            var page1 = baratLista.GetRange(0, 20);
            var page2 = baratLista.GetRange(20, 20);
            var page3 = baratLista.GetRange(40, 20);
            var page4 = baratLista.GetRange(60, 20);
            var page5 = baratLista.GetRange(80, 20);
            do
            {
                if (tovabb == 0)
                {
                    foreach (BaratLapoz key in page1)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 1)
                {
                    foreach (BaratLapoz key in page2)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 2)
                {
                    foreach (BaratLapoz key in page3)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 3)
                {
                    foreach (BaratLapoz key in page4)
                    {
                        key.printBarat();
                    }
                }
                else if (tovabb == 4)
                {
                    foreach (BaratLapoz key in page5)
                    {
                        key.printBarat();
                    }
                }
                var gomb = Console.ReadKey(true);
                if (gomb.Key == ConsoleKey.PageUp)
                {
                    Console.Clear();
                    tovabb = tovabb + 1;
                }
                else if (gomb.Key == ConsoleKey.Home)
                {
                    Console.Clear();
                    tovabb = 0;
                }
                else if (gomb.Key == ConsoleKey.End)
                {
                    Console.Clear();
                    tovabb = 4;
                }
                else if (gomb.Key == ConsoleKey.PageDown)
                {
                    Console.Clear();
                    tovabb = tovabb - 1;
                }
                else { Console.Clear(); continue; }
            } while (tovabb > -1 && tovabb < 5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaratLapoz b1 = new BaratLapoz();
            b1.bekeres();
            b1.kiir();
        }
    }
}
