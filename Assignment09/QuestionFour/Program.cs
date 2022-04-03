using System;

namespace QuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be counted: ");
            string someString = Console.ReadLine();


            int someStringCount = StringCount(someString);
            Console.WriteLine(someStringCount);
        }
        static int StringCount(string aString)
        {
            int count = 0;
            foreach (var item in aString)
            {
                count++;
            }
            return count;
        }
    }
}
