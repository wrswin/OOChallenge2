namespace OOChallenge2 {
    public abstract class Quadrilateral : Shape, IShapeCalc {
        public double SideLength1;
        public double SideLength2;
        public double SideLength3;
        public double SideLength4;

        public Quadrilateral(double sideLength1, double sideLength2, double sideLength3, double sideLength4) {
            SideLength1 = sideLength1;
            SideLength2 = sideLength2;
            SideLength3 = sideLength3;
            SideLength4 = sideLength4;
        }

        public abstract double GetArea();

        public double GetPerimeter() {
            return SideLength1 + SideLength2 + SideLength3 + SideLength4;
        }
    }
}