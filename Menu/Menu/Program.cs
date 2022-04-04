using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. menüpont");
            Console.WriteLine("2. menüpont");
            Console.WriteLine("3. menüpont");
            Console.WriteLine("4. menüpont");
            Console.WriteLine("5. menüpont kilépés");
            int melyik = 0;

            while(melyik != 5)
            {
                Console.WriteLine("Menüpont száma: ");
                melyik = int.Parse(Console.ReadLine());

                switch(melyik){ 
          case 1:Console.WriteLine
              ("Az elso menupontot valasztotta ki."); break; 
          case 2:Console.WriteLine
              ("A masodik menüpontot valasztotta ki."); break; 
          case 3:Console.WriteLine
              ("A harmadik menupontot valasztotta ki."); break; 
          case 4:Console.WriteLine
              ("A negyedik menupontot valasztotta ki."); break; 
          case 5:Console.WriteLine
             ("A kilepes menupontot valasztotta ki."); break;
                }
            }
            Console.ReadLine();
        }
    }
}
