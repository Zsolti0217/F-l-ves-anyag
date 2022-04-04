using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Listak
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> lista = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                lista.Add(rnd.Next(10, 100));
            }
            foreach(int i in lista)
            {
                Console.Write("{0}, ", i);
            }

        }
    }
}
