using System;

namespace WorkersSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Worker[] WorkersArray = {
                
                new Worker("John", 56765),
                new Worker("Jude", 4543.4),
                new Worker("Harry", 64334.8),
                new Worker("Sam", 85655.43),
                new Worker("Hannah", 6738),
                new Worker("Liza", 906669),
                new Worker("Erin", 2928),
                new Worker("Samira", 25112),
                new Worker("Bjorn", 300432),
                new Worker("Kuhl", 45002),


            };

            WorkerComparerDescending descComparison = new WorkerComparerDescending();

            Array.Sort(WorkersArray, descComparison);


            Console.WriteLine("Workers sorted according to their wages in descending order:");
            for (int i = 0; i < WorkersArray.Length; i++)
            {
                Console.WriteLine($"{WorkersArray[i].Name} earns {WorkersArray[i].Wages}");
            }
        }
    }
}
