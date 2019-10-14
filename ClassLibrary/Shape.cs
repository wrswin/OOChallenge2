using System;

namespace OOChallenge2 {
    public abstract class Shape {
        public string Colour;

        public Shape() {
            Colour = "red";
        }

        public void Operation1() {
            throw new NotImplementedException();
        }
    }
}