using System;
class NumberTwo
    {
        static void Main(string[] args)
        {
            bool arraysEqual = true;

            Console.Write("Enter  the length of first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter length of second array: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nArrays are the same.");
            }
      }
}