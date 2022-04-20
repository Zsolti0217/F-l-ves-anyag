using System;

namespace Matrix4
{
    class Matrixok
    {
        private int[,] matrix = new int[10, 10];
        private int rows;
        private int cols;
        private int sorindex;
        private int oszlopindex;
        private string key;

       

        public Matrixok(int rows, int cols, int sorindex,int oszlopindex,string key)
        {
            this.rows = rows;
            this.cols = cols;
            this.sorindex = sorindex;
            this.oszlopindex = oszlopindex;
            this.key = "a";
            
        }

        public Matrixok()
        {
            this.rows = 0;
            this.cols = 0;
            this.sorindex = -1;
            this.oszlopindex = -1;
            this.key = ",";

            
       
        }

        public void Fill()
        {
            bool folytatas = true;
            Console.WriteLine("Sorok és oszlopok száma: ");
            Console.WriteLine("Sorok száma: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Oszlopok száma: ");
            cols = int.Parse(Console.ReadLine());

            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n{0}. sor elemei:",  i +1);
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("{0} sor {1} elem: ", i + 1, j + 1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

               
            }

            while(folytatas ==true)
            {
                Console.WriteLine("Folytatod a beolvasást? (i/n)");
                key = Console.ReadLine();
               
            }
           
           
            if (key == "n")
            {
                folytatas = false;
                break;
                
            }

            if(key == "i")
            {
                Console.WriteLine("Add meg a sort: ");
                sorindex = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg az oszlopokat: ");
                oszlopindex = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg az értéket: ");
                matrix[sorindex - 1, oszlopindex - 1] = int.Parse(Console.ReadLine());
                if(matrix[sorindex -1,oszlopindex-1] < 0)
                {
                    Console.WriteLine("A megadot érték nem felel meg a feltételeknek , \n abszulut érték jelenik meg a tömbben.");
                    matrix[sorindex - 1, oszlopindex - 1] = Math.Abs(matrix[sorindex - 1, oszlopindex - 1]);
                }

                for (int i = 0; i < rows; i++)
                {
                    for(int j =0; i < cols; j++)
                    {
                        if (matrix[i,j] == 0)
                        {
                            matrix[i, j] = -1;
                            
                        }
                    }
                }

            }
        }

        public void Screen()
        {
            Console.WriteLine("Megadott mátrix: ");

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.WriteLine("{0}, matrix[i,j]");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("A mátrixban {0} db elem van kitöltve! ");
        }
        
        
        

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Matrixok m = new Matrixok();
            m.Fill();
            m.Screen();

            Console.ReadLine();
        }
    }
}
