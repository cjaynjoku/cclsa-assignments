using System;

internal class NumberTwelve
    {
        static void Main(string[] args)
        {
	 SquareMatrix();
	}
	private static void SquareMatrix()
        {
            Console.WriteLine("Enter the number of rows and columns in your square matrix");
            int M = Int32.Parse(Console.ReadLine());
            int N = M;
            int[,] matrixA = new int[M, N];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    string inputA;
                    int matrixValueA;
                    do
                    {
                        Console.WriteLine("Enter An *Integer* value for matrix A[" + (i + 1) + ", " + (j + 1) + "]");
                        inputA = Console.ReadLine();
                    } while (!Int32.TryParse(inputA, out matrixValueA));
                    matrixA[i, j] = matrixValueA;

                }

            }
            Console.WriteLine();
            Console.WriteLine("Your {0} x {1} square matrix=", M, N);
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {

                    Console.Write(" ".PadRight(2) + matrixA[i, j] + " ".PadLeft(2));
                }
                Console.WriteLine();

            }
        }
}