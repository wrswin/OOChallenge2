namespace OOChallenge2 {
    public class Square : Quadrilateral {
        public Square(double sideLength1, string colour) : base(sideLength1, sideLength1, sideLength1, sideLength1, colour) {

        }

        public override double GetArea() {
            return SideLength1 * SideLength1;
        }
    }
}