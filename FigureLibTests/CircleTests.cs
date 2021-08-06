using FigureLib;
using NUnit.Framework;
using System;

namespace FigureLibTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CreateValidCircle()
        {
            var radius = new Random().NextDouble();
            Assert.DoesNotThrow(() => new Circle(radius), "Исключение не ожидалось.");
        }

        [Test]
        public void CreateInvalidCircle(
            [Values (0, -1)] double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius), "Должно возникнуть исключение");
        }

        [Test]
        public void CheckArea()
        {
            var radius = new Random().NextDouble();
            var circle = new Circle(radius);
            var area = Math.PI * radius * radius;
            Assert.AreEqual(area, circle.CalculateArea(), "Площади должны совпадать.");
        }
    }
}