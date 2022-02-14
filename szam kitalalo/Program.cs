using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szam
{
    class Program
    {
        static void Main(string[] args)

        {
            //változok
            int alsohatar = 1; //véletlenszám alsó határa
            int  felsohatar = 11; //Véletlen szám felső határa +1
            int probal = 5; // A probálzokzások száma
            int gondoltSzam;
            int tippalsohatar;
            int tippfelsohatar;
            int tipp;
                   
              Random rnd = new Random();
            //Játék ismétlése
            do
            {
                //Megkérdezem, hogy ki lesz a kitaláló
                Console.WriteLine("Leszel az aki gondol a számra? (i/n)");
                if (Console.ReadKey().KeyChar == 'n') ;
                {
                    //Ha a játékos a kitaláló
                    // A gép gernerálja a kitalálandó számot
                    gondoltSzam = rnd.Next(felsohatar, alsohatar);
                    for (int i = 0; i =< probal) ;
                    {
                        //Beolvasom a tippet
                        Console.ReadLine();
                        Console.WriteLine("Tippeljen");
                        tipp = int.Parse(Console.ReadLine(();
                        //Ki értékelem a tippet
                        if(gondoltSzam < tipp)// Ha nagypbb a tipp
                        {
                            Console.WriteLine("Kisebb számra gondoltam");
                        }else if(gondoltSzam > tipp)// Ha kisebb a tipp
                        {
                            Console.WriteLine("Nagyobb számra gondoltam");
                        }
                        else // Ha eltalálta
                        {
                            Console.WriteLine("Gratulálok eltalálta");
                            break;
                        }
                    }
                }
                else
                {

                }
                
                Console.WriteLine("Folytatjuk a játékot? (i/n)");
            } while (Console.ReadKey().KeyChar == 'i');
            Console.ReadKey();

        }
    }
}
