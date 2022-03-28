using System;

class AssignmentFiveSwitch
    {
        static void Main(string[] args)
        {
	Switch();
	}

private static void Switch()
        {
            // Q5 Using switch statement

            int a = 1;
            int b = 6;
            int c = 5;
            int discriminant = (b * b) - (4 * a * c);
            Console.WriteLine(discriminant);
            switch (discriminant)
            {
                case 0:
                    Console.WriteLine("The equation has two equal roots");
                    break;
                case (>= 1):
                    Console.WriteLine("The equation has two distinct real roots");
                    break;
                case (< 0):
                    Console.WriteLine("The equation has complex roots");
                    break;
            }

        }
}