namespace OOChallenge2 {
    public class Circle : Shape, IShapeCalc {
        public readonly double PI = 3.141592653589793;

        public double Radius;

        public Circle(double radius) {
            Radius = radius;
        }

        public double GetArea() {
            return PI * Radius * Radius;
        }

        public double GetPerimeter() {
            return 2 * PI * Radius;
        }
    }
}