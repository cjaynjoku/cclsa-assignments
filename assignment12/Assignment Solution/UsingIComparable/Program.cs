using System;
using System.Collections.Generic;

namespace UsingIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentsArray = {
                new Student("John", 67),
                new Student("Jude", 45.77),
                new Student("Harry", 67.8),
                new Student("Sam", 83)
            };
            
            Array.Sort(studentsArray);


            Console.WriteLine("Students sorted based on Marks in an ascending order:");
            for (int i = 0; i < studentsArray.Length; i++)
            {
                Console.WriteLine($"{studentsArray[i].Name} scored {studentsArray[i].Mark}");
            }
        }
    }
}
