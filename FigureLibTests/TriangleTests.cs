using FigureLib;
using NUnit.Framework;
using System;

namespace FigureLibTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CreateValidCircle()
        {
            var side = new Random().NextDouble();
            Assert.DoesNotThrow(() => new Triangle(side, side, side), "Исключение не ожидалось.");
        }

        [Test]
        public void CreateInvalidTriangleWithFirstSide(
            [Values(0, -1)] double firstSide)
        {
            var secondSide = new Random().NextDouble();
            var thirdSide = new Random().NextDouble();
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide), "Должно возникнуть исключение");
        }

        [Test]
        public void CreateInvalidTriangleWithSecondSide(
            [Values(0, -1)] double secondSide)
        {
            var firstSide = new Random().NextDouble();
            var thirdSide = new Random().NextDouble();
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide), "Должно возникнуть исключение");
        }

        [Test]
        public void CreateInvalidTriangleWithThirdSide(
            [Values(0, -1)] double thirdSide)
        {
            var firstSide = new Random().NextDouble();
            var secondSide = new Random().NextDouble(); 
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide), "Должно возникнуть исключение");
        }

        [Test]
        public void CheckArea()
        {
            var firstSide = new Random().NextDouble();
            var secondSide = new Random().NextDouble();
            var thirdSide = new Random().NextDouble();
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            var area = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
            Assert.AreEqual(area, triangle.CalculateArea(), "Площади должны совпадать.");
        }

        [Test]
        public void CheckIsRightSuccess()
        {
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.IsTrue(triangle.IsRight(), "Площади должнен быть прямым.");
        }

        [Test]
        public void CheckIsRightFail()
        {
            var firstSide = new Random().NextDouble();
            var secondSide = new Random().NextDouble();
            var thirdSide = new Random().NextDouble();
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.IsFalse(triangle.IsRight(), "Площади не должен быть прямым.");
        }
    }
}
