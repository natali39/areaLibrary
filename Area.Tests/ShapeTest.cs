using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Area.Tests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void CallCalculateAreaOnAnyShape()
        {
            var circle = new Circle(5);
            var triangle = new Triangle(20, 15, 25);

            var result1 = GetArea(circle);
            var result2 = GetArea(triangle);

            Assert.AreEqual(78.5398, result1);
            Assert.AreEqual(150, result2);
        }

        static double GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
