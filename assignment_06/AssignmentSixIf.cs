using System;

class AssignmentSixIf
    {
        static void Main(string[] args)
        {
	SixIf();
	}

	public static void SixIf()
        {
            string a;
            string b;
            string c;
            int intA;
            int intB;
            int intC;

            do
            {
                Console.WriteLine("Enter the *Integer* coefficient of the first term:");
                a = Console.ReadLine();
            } while (!int.TryParse(a, out intA));

            do
            {
                Console.WriteLine("Enter the *Integer* coefficient of the second term:");
                b = Console.ReadLine();
            } while (!int.TryParse(b, out intB));
            do
            {
                Console.WriteLine("Enter the *Integer* constant term:");
                c = Console.ReadLine();
            } while (!int.TryParse(c, out intC));


            int discriminant = (intB * intB) - (4 * intA * intC);

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