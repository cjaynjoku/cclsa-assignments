using System;


namespace Shape
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle myShape = new Triangle(52, 7);
            Console.WriteLine(myShape.height);




            Shape shape1 = new Triangle(5, 8);
            Shape shape2 = new Rectangle(3, 9);
            Shape shape3 = new Circle(12);

            Shape[] shapesArray = new Shape[3]
            {
                shape1, shape2, shape3
            };

            PrintArray(shapesArray);

            double[] surfaceArray = new double[3]
            {
                shape1.CalculateSurface(),
                shape2.CalculateSurface(),
                shape3.CalculateSurface(),
            };



            PrintArray(surfaceArray);
        }

        public static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

    }
}
