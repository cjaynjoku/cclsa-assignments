using System;
class Assignment
{
		static void Main()
	{
	// Number 3
		double I = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());
            double w = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            double y = I - ((Math.Pow(f, n) * (((s * I) / f) + (Math.Pow((20/f), w))))/ Math.Pow(20, n));
            Console.WriteLine(y);


	// Number 4
            int a = 10;
            int b = 20;
            int c = 30;

            // If a = b
            if (a-b == 0)
            {
                Console.WriteLine("a is equal to b");
            }

            // If c > a+b-c
            if (c-(a+b-c) > 0)
            {
                Console.WriteLine("c is greater than a+b-c");
            }

            // If a = b
            if ((c-b) - a == 0)
            {
                Console.WriteLine("c-b is equal to a");
            }

	}
}