namespace Shape
{
    public class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return height * width / 2;
        }
        public Triangle(double width, double height) : base(width, height)
        {
        }

    }
}
