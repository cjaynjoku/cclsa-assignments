using System;
using System.Collections.Generic;

namespace QuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting the integer input
            string number1;
            int minimum;
            do
            {
                Console.WriteLine("Enter the integer lower limit of the range: ");
                number1 = Console.ReadLine();
            }
            while (!Int32.TryParse(number1, out minimum));

            string number2;
            int maximum;
            do
            {
                Console.WriteLine("Enter the integer upper limit of the range: ");
                number2 = Console.ReadLine();
            }
            while (!Int32.TryParse(number2, out maximum));

            
            // Method Call
            if (minimum < maximum)
            {
                RandomNumbers(minimum, maximum);
            }
            else
                (minimum, maximum) = (maximum, minimum);
                RandomNumbers(minimum, maximum);

        }

        static void RandomNumbers(int min, int max)
        {

            Random RandomNumber = new Random();
            int number = RandomNumber.Next(min, max);
            List<int> randomList = new List<int>();

            int count = 0;
            while (!randomList.Contains(number))
            {
                count++;
                randomList.Add(number);
                number = RandomNumber.Next(min, max);

            }
            PrintList(randomList);
            Console.WriteLine();
            Console.WriteLine("The repeated number is: {0}", number);

            Console.WriteLine($"The program converged after {count} iterations.");

        }
       
        static void PrintList(List<int> aList)
        {
            for (int i = 0; i < aList.Count; i++)
            {
                Console.WriteLine(aList[i]);
            }
        }
    }
}
