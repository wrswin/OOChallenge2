namespace OOChallenge2 {
    public class Rectangle : Quadrilateral {
        public Rectangle(double sideLength1, double sideLength2) : base(sideLength1, sideLength2, sideLength1, sideLength2) {

        }

        public override double GetArea() {
            return SideLength1 * SideLength2;
        }
    }
}