using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Area.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestCalculateArea()
        {
            var triangle = new Triangle(6, 7, 8);

            var result = triangle.CalculateArea();

            Assert.AreEqual(20.3332, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Значение сторон должно быть больше нуля")]
        public void InputValueIsNegative()
        {
            var triangle = new Triangle(-1, -1, -1);
        }

        [TestMethod]
        public void ExsistsTriangle()
        {
            var triangle = new Triangle(2, 2, 2);

            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Треугольник с такими сторонами не существует")]
        public void NotExistsTriangle()
        {
            var triangle = new Triangle(1, 1, 2);
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(20, 15, 25);
            
            var result = triangle.IsRightTriangle();

            Assert.AreEqual(true, result);
        }
    }
}
