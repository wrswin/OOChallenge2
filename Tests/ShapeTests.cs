using System;
using NUnit.Framework;

namespace OOChallenge2.Tests {
    [TestFixture]
    public class ShapeTests {
        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTest(double sideLength1, double area, double perimeter) {
            var square = new Square(sideLength1);

            AssertCalc(square, area, perimeter);
        }

        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTest(double sideLength1, double sideLength2, double area, double perimeter) {
            var rectangle = new Rectangle(sideLength1, sideLength2);

            AssertCalc(rectangle, area, perimeter);
        }

        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTest(double sideLength1, double area, double perimeter) {
            var equilateral = new Equilateral(sideLength1);

            AssertCalc(equilateral, area, perimeter);
        }

        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTest(double sideLength1, double sideLength2, double area, double perimeter) {
            var rightAngle = new RightAngle(sideLength1, sideLength2);

            AssertCalc(rightAngle, area, perimeter);
        }

        [TestCase(5, 78.55, 31.42)]
        [TestCase(15, 706.95, 94.26)]
        [TestCase(7, 153.96, 43.99)]
        public void CircleTest(double radius, double area, double perimeter) {
            var circle = new Circle();
            circle.Radius = radius;

            AssertCalc(circle, area, perimeter);
        }

        void AssertCalc(IShapeCalc shape, double area, double perimeter) {
            Assert.AreEqual(Math.Round(area), Math.Round(shape.GetArea()));
            Assert.AreEqual(Math.Round(perimeter), Math.Round(shape.GetPerimeter()));
        }
    }
}