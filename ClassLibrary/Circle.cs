namespace OOChallenge2 {
    public class Circle : Shape, IShapeCalc {
        public readonly double PI = 3.141592653589793;

        public double Radius;

        public double GetArea() {
            return PI * Radius * Radius;
        }

        public double GetPerimeter() {
            return 2 * PI * Radius;
        }
    }
}