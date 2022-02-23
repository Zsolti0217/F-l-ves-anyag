using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nszam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random ;

            int a,b,c,d;

            Console.WriteLine("Alsó határ:");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Felső határ:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("5-el osztható számok:");

            for(c = a; c<=b, c = c + 1)
            {
                if(c % 5 == 0)
                    Console.WriteLine("{0}", c);
            }

            Console.ReadLine();

        }
    }
}
