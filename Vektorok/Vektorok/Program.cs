using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektor
{
    class Vektor
    {
        public int size;
        public int sum;
        public double average;
        public int max;
        public int min;
        //private int[] numbers = new int[10];
        Random rnd = new Random();

        public Vektor(int size)
        {
            this.size = size;
            this.sum = 0;
            this.max = 0;
            this.min = 101;
            this.average = 0;
        }
        
        // Getter - Setter
        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        // Elemek összege
        public int Sum(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("\nA tömb elemeinek összege: {0}", sum);
            return sum;
        }

        // Maximum
        public void Maximum(int[] numbers)
        {
            int maxindex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (this.max < numbers[i])
                {
                    this.max = numbers[i];
                    maxindex = i;
                    Console.WriteLine("Követő: A max értéke: " + max);
                }
            }
            Console.WriteLine("\nA tömb maximuma: {0}, indexe: {1}\n", max, maxindex);
            //return max;
        }

        // Minimum
        public void Minimum(int[] numbers)
        {
            int minindex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (this.min > numbers[i])
                {
                    this.min = numbers[i];
                    minindex = i;
                    Console.WriteLine("Követő: A min értéke: " + min);
                }
            }
            Console.WriteLine("\nA tömb minimuma: {0}, indexe: {1}\n", min, minindex);
            //return min;
        }

        // Átlag
        public void Avg(int[] numbers)
        {
            average = sum / size;
            Console.WriteLine("A tömb átlaga: " + average);
        }


    }

                             //////////////////////////// MÁTRIX ////////////////////////////////

    class Matrix : Vektor
    {
        private int a;
        private int b;

        public Matrix(int a, int b, int sum, int max, int min, double avarage) : base()
        {
            this.a = a;
            this.b = b;
        }

        public int getSize(int a, int b)
        {
            int size = a * b;
            return size;
        }



        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Add meg a tömb méretét: ");
                int hossz = int.Parse(Console.ReadLine());
                Random rnd = new Random();



                Vektor vektor = new Vektor(hossz);
                int[] numbers = new int[hossz];

                for (int i = 0; i < hossz; i++)
                {
                    numbers[i] = rnd.Next(0, 100);
                }

                 

                Console.WriteLine("\nA tömb elemei: ");

                for (int i = 0; i < hossz; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                // Összeg
                vektor.Sum(numbers);

                // Maximum
                vektor.Maximum(numbers);

                // Minimum
                vektor.Minimum(numbers);

                // Átlag
                vektor.Avg(numbers);

                Console.WriteLine("\n ***MÁTRIX***\n");
                
                Console.WriteLine("Add meg a mátrix sorainak számát: ");
                int.sor = int.Parse(Console.ReadLine());


                

                 
                


                //Console.WriteLine(numbers);

                Console.ReadLine();

                //Vektor.setSize(hossz);


            }
        }
    }
}