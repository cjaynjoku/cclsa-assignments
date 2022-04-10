namespace Shape
{
    public class Rectangle: Shape
    {
        public override double CalculateSurface()
        {
            return height * width;
        }

        public Rectangle(double width, double height):base(width, height)
        {
        }
    }
}
