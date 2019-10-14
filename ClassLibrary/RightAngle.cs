using System;

namespace OOChallenge2 {
    public class RightAngle : Triangle, IShapeCalc {
        public RightAngle(double sideLength1, double sideLength2) : base(sideLength1, sideLength2, 0) {
            SetHypotenuse();
        }
        
        public void SetHypotenuse() {
            SideLength3 = Math.Sqrt(SideLength1 * SideLength1 + SideLength2 * SideLength2);
        }

        public double GetArea() {
            return 0.5 * SideLength1 * SideLength2;
        }

        public double GetPerimeter() {
            return SideLength1 + SideLength2 + SideLength3;
        }
    }
}