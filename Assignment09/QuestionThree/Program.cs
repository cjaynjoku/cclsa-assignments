using System;

namespace QuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            int result;
            do
            {
                Console.Write("Enter a number between 1 and 100 to be spelt: ");
                number = Console.ReadLine();

            }
            while (!Int32.TryParse(number, out result));
            PrintWordsInANumber(result);
        }

        static void PrintWordsInANumber(int number)
        {

            if (number.ToString().Length == 2 && number > 19)
            {
                int sNumber = number % 10;
                int fNumber = number - sNumber;
                PrintWordsInANumberSwitch(fNumber);
                Console.Write(" ");
                PrintWordsInANumberSwitch(sNumber);
            }
            else
            {
                PrintWordsInANumberSwitch(number);
            }
        }
        static void PrintWordsInANumberSwitch(int number)
        {

            switch (number)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                case 10:
                    Console.Write("Ten");
                    break;
                case 11:
                    Console.Write("Eleven");
                    break;
                case 12:
                    Console.Write("Twelve");
                    break;
                case 13:
                    Console.Write("Thirteen");
                    break;
                case 14:
                    Console.Write("Fourteen");
                    break;
                case 15:
                    Console.Write("Fifteen");
                    break;
                case 16:
                    Console.Write("Sixteen");
                    break;
                case 17:
                    Console.Write("Seventeen");
                    break;
                case 18:
                    Console.Write("Eighteen");
                    break;
                case 19:
                    Console.Write("Nineteen");
                    break;
                case 20:
                    Console.Write("Twenty");
                    break;
                case 30:
                    Console.Write("Thirty");
                    break;
                case 40:
                    Console.Write("Forty");
                    break;
                case 50:
                    Console.Write("Fifty");
                    break;
                case 60:
                    Console.Write("Sixty");
                    break;
                case 70:
                    Console.Write("Seventy");
                    break;
                case 80:
                    Console.Write("Eighty");
                    break;
                case 90:
                    Console.Write("Ninety");
                    break;
                case 100:
                    Console.Write("One Hundred");
                    break;
            }


        }


    }
}
