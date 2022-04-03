using System;

namespace Assignment09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstCoefficient;
            double firstResult;
            do
            {
                Console.Write("Enter the coefficient of the first term: ");
                firstCoefficient = Console.ReadLine();

            }
            while (!double.TryParse(firstCoefficient, out firstResult));

            string secondCoefficient;
           double secondResult;
            do
            {
                Console.Write("Enter the coeffient of the second term: ");
                secondCoefficient = Console.ReadLine();

            }
            while (!double.TryParse(secondCoefficient, out secondResult));

            string constantTerm;
            double constantResult;
            do
            {
                Console.Write("Enter the constant term: ");
                constantTerm = Console.ReadLine();

            }
            while (!double.TryParse(constantTerm, out constantResult));
           
            // Method Invocation
            double[] anAnswer = QuadraticSolver(firstResult, secondResult, constantResult);
           
            Console.WriteLine("The roots of the equation are: ");
            for (int i = 0; i < anAnswer.Length; i++)
            {
                Console.WriteLine(anAnswer[i]);
            }
        }

        static double[] QuadraticFunctionSolver(double a, double b, double c)
        {
            double[] answerArray = new double[2];
           
            double firstRoot = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * a;
            double secondRoot = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / 2 * a;
           
            answerArray[0] = firstRoot;
            answerArray[1] = secondRoot;

            return answerArray;
        }

    }

}
