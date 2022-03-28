using System;

class AssignmentFiveIf
    {
        static void Main(string[] args)
        {
	FiveIf();
	}

	private static void FiveIf()
        {
            int a = 1;
            int b = 6;
            int c = 5;
            int discriminant = (b * b) - (4 * a * c);
            Console.WriteLine(discriminant);
            if (discriminant == 0)
            {
                Console.WriteLine("The equation has two equal roots");
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("The equation has two distinct real roots");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("The equation has complex roots");
            }
        }
}