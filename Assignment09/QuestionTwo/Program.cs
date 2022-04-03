using System;

namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            int result;
            do
            {
                Console.Write("Enter a number to find the factorial");
                number = Console.ReadLine();

            }
            while (!Int32.TryParse(number, out result));
            

            int factorialAnswer = Factorial(result);
            Console.WriteLine(factorialAnswer);
            
        }

        static int Factorial(int number)
        {
            int factorial = 1;
            if (number > 0)
            {
                while (number > 0)
                {
                    factorial *= number;
                    number--;

                }
            }
            else if (number == 0)
            {
                factorial = 1;
            }
            return factorial;
        }
    }
}
