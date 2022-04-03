using System;
using System.Collections.Generic;

namespace QuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Getting the lower and upper limits as inputs
            string number1;
            int start;
            do
            {
                Console.WriteLine("Enter the integer lower limit of the rsnge: ");
                number1 = Console.ReadLine();
            }
            while (!Int32.TryParse(number1, out start));

            string number2;
            int stop;
            do
            {
                Console.WriteLine("Enter the integer upper limit of the rsnge: ");
                number2 = Console.ReadLine();
            }
            while (!Int32.TryParse(number2, out stop));


            PrimeNumbersWithinARange(start, stop);
        }
        static void PrimeNumbersWithinARange(int start, int stop)
        {
            if (start >= stop)
            {
                return;
            }
            else
            {
                List<int> factors = new List<int>();

                for (int i = 1; i < Math.Sqrt(start); i++)
                {
                    if (start % i == 0)
                    {
                        factors.Add(i);
                    }
                }
                if (factors.Count == 1)
                {
                    Console.WriteLine(start);
                }
            }
            PrimeNumbersWithinARange(start + 1, stop);
        }
    }
}
