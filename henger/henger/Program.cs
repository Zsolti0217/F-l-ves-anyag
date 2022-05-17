using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hengerr
{
    class Henger
    {
        private double radius;
        private double height;
        private double Pi = 3,1408;
        private double circlePerimeter;
        private double rectanglePerimeter;
        private double circleSurface;
        private double barrelSurface;
        private double barrelCapacity;
        public henger()
        {
            this.radius = 0;
            this.height = 0;
        }

        public void setSugar()
        {
            Console.WriteLine("Add meg az alapkör sugarát: ");
            radius = float.Parse(Console.ReadLine());
        }

        public void setMagas()
        {
            Console.WriteLine("Add meg a magasságot: ");
            height = float.Parse(Console.ReadLine());
        }

        public void getKerulet()
        {
            Console.WriteLine("Add meg a kerületét: ");
            circlePerimeter = 2 * radius * Pi;
            rectanglePerimeter = (circlePerimeter + height) * 2;
            Console.WriteLine("\n Alap kör kerület: {0}, \n A palást kerület: [1] ", circlePerimeter, rectanglePerimeter);

        }

        public void getTerulet()
        {
            circleSurface = radius * radius * Pi;
            Console.WriteLine("\n Az alap kör területe : {0} ", circleSurface);


        }

        public void getFelszin()
        {
            barrelSurface = circleSurface * 2 + circlePerimeter * height;
            Console.WriteLine("\n A henger felülete: {0}", barrelSurface); 
        }



        public void getTerfogat()
        {
            barrelCapacity = circleSurface * height;
            Console.WriteLine("\n A henger térfogata: ");
        }
}

  
    {
        static void Main(string[] args)
    {
        Henger h1 = new Henger();
        h1.setSugar();
        h1.setMagas();
        h1.getKerulet();
        h1.getTerulet(),
        h1.getFelszin();
        h1.getTerfogat();
    }
}



   