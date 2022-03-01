using System;

namespace Allat
{
    class Allat
    {
        private string nev;
        private string fajta;
        private string szin;
        private int kor;


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





        class Program
        {
            static void Main(string[] args)
            {
                Allat allat1 = new Allat("Bodri", "Puli", "fekete");
                allat1.setKor(2);
                Console.WriteLine("Az allat1 neve: {0}", allat1.getnev(), allat1.getkor());

                Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
                Console.WriteLine("Az allat2 neve: {0}", allat2.getnev());

                Allat allat3 = new Allat("Bolhás", "Komondor", "fehér");
                Console.WriteLine("Az allat3 neve: {0}", allat3.getnev());



                Console.ReadKey();

            }
        }
    }
}
