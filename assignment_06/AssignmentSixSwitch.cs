using System;

class AssignmentSixSwitch
    {
        static void Main(string[] args)
        {
	Switch();
	}

	 private static void Switch()
        {
            string a;
            string b;
            string c;
            int intA;
            int intB;
            int intC;


            // Q6 using switch statement
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