using System;

namespace QuestionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number, n to find the sum of the first n numbers: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine(SumOfAllNNumbers(number));

        }
        static int SumOfAllNNumbers(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number += SumOfAllNNumbers(number - 1);
            }

        }
    }
}
