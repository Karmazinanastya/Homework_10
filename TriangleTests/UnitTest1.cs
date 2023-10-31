using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;


namespace Triangle.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Distance_p1andp2_5returned()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(3, 4);

            double expectedDistance = 5.0;
            double actualDistance = point1.Distance(point2);

            Assert.AreEqual(expectedDistance, actualDistance, 0.001);
        }

        [TestMethod]
        public void Distance_p2andp3_5returned()
        {
            Point point2 = new Point(3, 3);
            Point point3 = new Point(1, 1);

            double expectedDistance = 2.8284271247461903;
            double actualDistance = point2.Distance(point3);

            Assert.AreEqual(expectedDistance, actualDistance, 0.001);
        }
    }  
}