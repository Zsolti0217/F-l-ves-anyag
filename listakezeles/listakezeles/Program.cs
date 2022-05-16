using System;

namespace listakezeles
{
    class Varosnevek
    {
        private List<string> varosok = new List<string>();
        private string varosInput;
        private int listsize;


        public CitynevekList()
        {
            this.varosInput = "";
            this.listsize = 0;
        }

        public int setDb()
        {
            Console.WriteLine("Add meg hány városnevet szeretnél eltárolni: ");
            listsize = int.Parse(Console.ReadLine());

            return listsize;
        }

        public void setNevek()
        {
            Console.WriteLine("Add meg a városok neveit: ");
           
             while(varosInput !="")
            {
                if ((listsize == 0) || (listsize.ToString() == ""))
                {
                    break;
                }
                varosInput = Console.ReadLine();
                varosok.Add(varosInput);

            }

           
        }

        public void getNevek()
        {
            Console.WriteLine("\n A tárolt nevek a következők : ");

            for (int i = 0; i < listsize; i++)
            {
                Console.WriteLine("{0}, ", varosok[0]);
            }

        }


        public void getVan()
        {
            bool nameExists = false;
            string nameCheck;
            Console.WriteLine("Melyik várost akarod ellenőrizni: ");
            nameCheck = Console.ReadLine();

            for(int i = 0; i < listsize; i++)
            {
                if (nameCheck == varosok[i])
                {
                    Console.WriteLine("A megadott név rajta van a  listán.");
                    nameExists = true;
                    break;
                }

                if (!nameExists)
                {
                    Console.WriteLine("A megadott név nem szerepel a listán.");
                }
            }
        }


        public void delNev()
        {
            getVan();
            bool nameExists = false;
            string nameCheck;
            Console.WriteLine("Melyik várost akarod hozzáadni/elveni: ");
            nameCheck = Console.ReadLine();

            for (int i = 0; i < listsize; i++)
            {
                if (nameCheck == varosok[i])
                {
                    Console.WriteLine("A megadott név törlésre került a  listáról.");
                    nameExists = true;
                    break;
                }

                if (!nameExists)
                {
                    Console.WriteLine("A megadott név nem szerepel a listán.");
                }
            }
        }
    }


        public void delLast()
        {

        }
       
        

       





    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
