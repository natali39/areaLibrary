using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Area.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestCalculateArea()
        {
            var circle = new Circle(5);

            var result = circle.CalculateArea();

            Assert.AreEqual(78.5398, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Радиус не может быть отрицательным")]
        public void InputNegativRadius()
        {
            var circle = new Circle(-10);
        }
    }
}
