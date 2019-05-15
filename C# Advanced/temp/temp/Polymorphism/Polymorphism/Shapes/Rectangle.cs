using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        private double hight;
        private double width;

        public Rectangle(double hight, double width)
        {
            this.hight = hight;
            this.width = width;
        }

        public override double CalculatePerimeter()
        {
            return this.hight * 2 + this.width * 2;
        }

        public override double Area()
        {
            return this.hight * this.width;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
}
