using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BarrelRoll;

namespace Henger2test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double getKeruletTest(double radius, double PI)
            {
                return 2 * radius * PI;
            }

            double getTeruletTest(double radius, double PI)
            {
                return radius * radius * PI;
            }

            double getFelszinTest(double circleSurface, double circlePerimeter, double height)
            {
                return circleSurface * 2 + circlePerimeter * height;
            }

        }
    }
}
