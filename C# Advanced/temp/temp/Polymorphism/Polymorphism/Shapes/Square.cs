using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : Shapes
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override string Draw()
        {
            return base.Draw() + " Square";
        }
    }
}
