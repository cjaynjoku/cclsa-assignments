namespace Shape
{
    public abstract class Shape
    {
        public double width;
        public double height;

        public double Width 
        {
            get { return width; }
            set { this.width = value; } 
        }
        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }


        public abstract double CalculateSurface();

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
