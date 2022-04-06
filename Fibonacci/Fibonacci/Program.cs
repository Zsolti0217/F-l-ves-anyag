using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibon = new int[]
                {0,1,2,3,4,5,8,13};
            Console.Write("A fibonacci sorazat pár tagja: ");

            foreach (int f in fibon)
            {
                Console.Write("{0}, ", f);
            }
            Console.ReadLine();
        }
       
    }
}
