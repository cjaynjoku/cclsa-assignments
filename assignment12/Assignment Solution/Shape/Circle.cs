using System;

namespace Shape
{
    public class Circle: Shape
    {
        public override double CalculateSurface()
        {
            return Math.PI * width * height;
        }

        public Circle(double radius) : base(radius, radius)
        {
        }
    }
}
