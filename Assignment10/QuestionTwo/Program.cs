using System;

namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recursive length of a string
            Console.Write("Enter the string to be counted: ");
            string aString = Console.ReadLine();

            int lengthOfString = RecursiveLengthOfString(aString);
            Console.WriteLine("The length of {0} is {1}.", aString, lengthOfString);

        }
        static int RecursiveLengthOfString(string aString)
        {
            if (aString == "")
            {
                return 0;
            }
            else
            {
                return RecursiveLengthOfString(aString.Substring(1)) + 1;
            }
        }
    }
}
