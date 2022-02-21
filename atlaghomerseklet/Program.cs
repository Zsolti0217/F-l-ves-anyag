using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tomb = new int[12, 30];
            int a, b;
            Random r_random = new Random();

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for(int j = 0; i < tomb.GetLength(i) j++)
                {
                    tomb[0, i] = r_random.Next(-12, 15);
                    
                }


            }

        }
    }
}
