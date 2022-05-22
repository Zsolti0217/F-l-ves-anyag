using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Barrel;

namespace HengertestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public double getKeruletTest(double radius, double PI)
        {
            return 2 * radius * PI;
        }

        public double getTeruletTest(double radius, double PI)
        {
            return radius * radius * PI;
        }

        public double getFelszinTest(double circleSurface, double circlePerimeter, double height)
        {
            return circleSurface * 2 + circlePerimeter * height;
        }



    }
}
