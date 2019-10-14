namespace OOChallenge2 {
    public abstract class Triangle : Shape {
        public double SideLength1;
        public double SideLength2;
        public double SideLength3;

        public Triangle(double sideLength1, double sideLength2, double sideLength3) {
            SideLength1 = sideLength1;
            SideLength2 = sideLength2;
            SideLength3 = sideLength3;
        }
    }
}