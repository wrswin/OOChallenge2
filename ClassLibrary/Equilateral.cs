using System;

namespace OOChallenge2 {
    public class Equilateral : Triangle, IShapeCalc {
        public Equilateral(double sideLength1, string colour) : base(sideLength1, sideLength1, sideLength1, colour) {
            
        }

        public double GetArea() {
            return Math.Sqrt(3) / 4 * SideLength1 * SideLength1;
        }

        public double GetPerimeter() {
            return SideLength1 + SideLength2 + SideLength3;
        }
    }
}