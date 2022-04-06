using System;

namespace Prog2
{
    class Elagazas
    {
        public int 
    }
   
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new int List<int>();
            Random rnd = new Random();

            for(int i = 0; i <10; i++)
            {
                lista.Add(rnd.Next(10,100));
            }
            Console.WriteLine("A lista páros elemei! ");

            foreach(int i in lista)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}," , i")
                }
                
            }
            Console.ReadKey();
        }
    }
}
