using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Henger
{
    class Barrel
    {
        private double radius;
        private double height;
        private static double PI = 3.14159;
        private double circlePerimeter;
        private double rectanglePerimeter;
        private double circleSurface;
        private double barrelSurface;
        private double barrelCapacity;

        public Barrel()
        {
            this.radius = 0;
            this.height = 0;
        }

        public void setSugar()
        {
            Console.WriteLine("Add meg az alap kör sugarát");
            radius = double.Parse(Console.ReadLine());
        }

        public void setMagas()
        {
            Console.WriteLine("Add meg a hengerpalást magasságát");
            height = double.Parse(Console.ReadLine());
        }

        public void getKerulet()
        {
            Console.WriteLine("\n A függvény kiszámolja az alap kör kerületét, és a palást téglalap kerületét.");

            circlePerimeter = 2 * radius * PI;
            rectanglePerimeter = (circlePerimeter + height) * 2;
            Console.WriteLine("\nAlap kör kerülete: {0}\nA palást kerülete: {1}", circlePerimeter, rectanglePerimeter);
        }

        public void getTerulet()
        {
            circleSurface = radius * radius * PI;
            Console.WriteLine("\nAz alap kör területe: {0}", circleSurface);
        }

        public void getFelszin()
        {
            barrelSurface = circleSurface * 2 + circlePerimeter * height;
            Console.WriteLine("\nA henger felülete: {0}", barrelSurface);
        }

        public void getTerfogat()
        {
            barrelCapacity = circleSurface * height;
            Console.WriteLine("\nA henger térfogata: {0}", barrelCapacity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Barrel b1 = new Barrel();
            b1.setSugar();
            b1.setMagas();
            b1.getKerulet();
            b1.getTerulet();
            b1.getFelszin();
            b1.getTerfogat();

            Console.ReadLine();
        }
    }
}

