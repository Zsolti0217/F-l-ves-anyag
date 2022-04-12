using System;

namespace Matrixok1
{
    class MatrixBill
    {
        private int[,] matrix = new int[10, 10];
        private int rows;
        private int cols;

        public MatrixBill(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public MatrixBill()
        {
            this.rows = 0;
            this.cols = 0;

        }

        public void Fill()
        {
            Console.WriteLine("Add meg hány sora és oszlopa lesz a mátrixnak: ");
            Console.WriteLine("Sorok száma: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Oszlopok száma: ");
            cols = int.Parse(Console.ReadLine());

            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n{0}, sor elemei:", i+1);
                for(int j = 0; j < cols; j++)
                {

                }
            }
        }
    }



    


    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
