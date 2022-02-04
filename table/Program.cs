using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
              //Két parancssori paraméter száma is lehet: 0,1,2,3*/
              int param = args.Length;//paraméter száma  
              int  szam1 = 0; //1.paraméter értéke
              int szam2 = 0; //2. paraméter értéke

            Random rnd = new Random();


            switch(param)
            {
                case 0
                    szam1 =rnd.Next(1,100);
                    szam2 =rnd.Next(1,100);
                    break;

                case 1:
                    szam1 =int.Parse(args[0]);
                    szam2 = rnd.Next(1, 100);
                    break;

                case 2 :
                    szam1=int.Parse(args[0]);
                    szam2=int.Parse(args[0]);
            }

            
               
            }
            //Kiiratom a végeredményt
            Console.WriteLine(szam1 * szam2);
            Console.ReadKey()
        }
    }
}
