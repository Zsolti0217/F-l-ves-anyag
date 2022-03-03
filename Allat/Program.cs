using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allat
{
    class Allat
    {
        private string nev;
        private string fajta;
        private string szin;
        private int kor;
         string hang;


        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

       
        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "fekete";
            this.kor = 0;
        }
        
        public void setNev(string p)
        {
            this.nev = p;
        }
            
            
         public string getnev()
        {
            return this.nev;
        }

        public string getkor()
        {
            return this.getkor();
        }



        public void setKor(int p)
        {
            if (p > 0 && p < 50)
            {
                this.kor = p;
            }
        }


        public void setFajta()
        {
            return this.fajta();
        }

        public void setFajta(string p){this.fajta = p;}
        public string getFajta() { return this.fajta}

        public void setSzin(string p) { this.szin = p;}
        public string getSzin() { return this.szin}


        public string hangotAd()
        {
            return this.hang;
        }

        class Kutya : Allat
        {
            //Oszályváltozó
            private string gazda;

            public Kutya(string nev, string fajta, string szin) : base(string nev, string fajta, string szin)
            {
                this.gazda = "ismeretlen";
                this.hang = "vau vau";
            }


        }


        //Polimorfizmus példa
        class Home
        {
            //Osztályváltozó
            List<Allat> szobak = new List<Allat>();
            Random r = new Random();


            public Home(){}

            public void allatAdd(Allat p)
            {
                this.szobak.Add(Allat p)
            }

            public Allat getAllat()
            {
                return this.szobak[r.Next(0, this.szobak.Count)];
            }
        }



        class Program
        {
            static void Main(string[] args)
            {
                Allat allat1 = new Allat("Bodri", "Puli", "fekete");
                allat1.setKor(2);
                Console.WriteLine("Az allat1 neve: {0}", allat1.getnev(), allat1.getkor());

                Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
                Console.WriteLine("Az allat2 neve: {0}", allat2.getnev());

               Allat allat3 = new Allat();
                allat3.setNev("Vadász");
                allat3.setFajta("Agár");
                allat3.setSzin("barna");
                allat3.setKor("5");

                Console.WriteLine("\n Az allat3 neve: {0}", allat1.getnev());

               Console.WriteLine("\n Az allat3 hangja: {0}", allat3 hangotAd());
                Console.WriteLine("\n============= Származtatott ===========\n");
                Kutya kutya1 = new Kutya("Bogár", "Puli", "fekete")


                //poliformizmus példa
                Console.WriteLine("==============Poliformizmus példa ============");

                //pédányosítjuk a Home-ot
                Home   sweetHome = 


                Console.ReadKey();

            }
        }
    }
}