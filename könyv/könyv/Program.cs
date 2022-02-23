using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace könyv
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 0;
            int oldalai = 0;

            string k = "k";
            while (k != "") ;
            {
                Console.WriteLine("Add meg a könyv címét: ");
                k1 = Console.ReadLine();
                Console.WriteLine("Rövid terjedelmű könyv");
                oldalai =Convert.ToInt32(Console.ReadLine());

                if (oldalai < 150) 
                {
                    Console.WriteLine("A {0} rövid terjedelmű könyv");
                }
                else if(oldalai > 150)
                {
                    Console.WriteLine("A {0} hosszú terjedelmű könyv ");
                }
                


            }
        }
    }
}
