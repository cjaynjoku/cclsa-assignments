using System;

internal class Matrices
{
        static void Main(string[] args)
        {
	 myArrays();
	    }

	 private static void myArrays()
        {
            int[] myArray = new int[5] { 2, 4, 3, 4, 5, };

            double[,] multArray = new double[2, 4]
            {
                {2, 5, 3, 5},
                {1, 2, 3, 4},
            };

            int[,,,] my4DArray = new int[2, 3, 5, 4]
            {
                {
                 {{1, 1, 1, 1},
                {2, 2, 2, 2},
                {3, 3, 3, 3},
                {4, 4, 4, 4},
                {5, 5, 5, 5} },

                {{6, 6, 6, 6},
                {7, 7, 7, 7},
                {8, 8, 8, 8},
                {9, 9, 9, 9},
                {10, 10, 10, 10} },

                {{11, 11, 11, 11},
                {12, 12, 12, 12},
                {13, 13, 13, 13},
                {14, 14, 14, 14},
                {15, 15, 15, 15} }
                },

                {
                    {{1, 1, 1, 1},
                    {2, 2, 2, 2},
                    {3, 3, 3, 3},
                    {4, 4, 4, 4},
                    {5, 5, 5, 5} },

                    {{6, 6, 6, 6},
                    {7, 7, 7, 7},
                    {8, 8, 8, 8},
                    {9, 9, 9, 9},
                    {10, 10, 10, 10} },

                    {{11, 11, 11, 11},
                    {12, 12, 12, 12},
                    {13, 13, 13, 13},
                    {14, 14, 14, 14},
                    {15, 15, 15, 15} }
                }

            };

            // 3 x 3 matrix operations

            int[,] matrixA = new int[3, 3];
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
            Console.WriteLine("matrixA =");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {

                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();

            }


            // Matrix B

            int[,] matrixB = new int[3, 3];
            for (int j = 0; j < matrixB.GetLength(0); j++)
            {
                for (int k = 0; k < matrixB.GetLength(1); k++)
                {
                    string inputB;
                    int matrixValueB;
                    do
                    {
                        Console.WriteLine("Enter An *Integer* value for matrix B[" + (j + 1) + ", " + (k + 1) + "]");
                        inputB = Console.ReadLine();
                    } while (!Int32.TryParse(inputB, out matrixValueB));
                    matrixB[j, k] = matrixValueB;

                }

            }
            Console.WriteLine();
            Console.WriteLine("matrixB =");
            for (int j = 0; j < matrixB.GetLength(0); j++)
            {
                for (int k = 0; k < matrixB.GetLength(1); k++)
                {

                    Console.Write(matrixB[j, k] + " ");
                }
                Console.WriteLine();
            }


            // Addition of the two 3 x 3 matrices
            int[,] matrixAdd = new int[3, 3];
            for (int i = 0; i < matrixAdd.GetLength(0); i++)
            {
                for (int j = 0; j < matrixAdd.GetLength(1); j++)
                {
                    matrixAdd[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            Console.WriteLine();
            Console.WriteLine("matrixA + matrixB =");
            for (int i = 0; i < matrixAdd.GetLength(0); i++)
            {
                for (int j = 0; j < matrixAdd.GetLength(1); j++)
                {

                    Console.Write(matrixAdd[i, j] + " ");
                }
                Console.WriteLine();

            }


            // Subtraction of the two 3 x 3 matrices
            int[,] matrixSubtract = new int[3, 3];
            for (int i = 0; i < matrixSubtract.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSubtract.GetLength(1); j++)
                {
                    matrixSubtract[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("matrixA - matrixB =");
            for (int i = 0; i < matrixSubtract.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSubtract.GetLength(1); j++)
                {

                    Console.Write(matrixSubtract[i, j] + " ");
                }
                Console.WriteLine();

            }

            // Finding the determinants
            int determinantA = (matrixA[0, 0] * ((matrixA[1, 1] * matrixA[2, 2]) - (matrixA[2, 1] * matrixA[1, 2]))) -
                (matrixA[0, 1] * ((matrixA[1, 0] * matrixA[2, 2]) - (matrixA[2, 0] * matrixA[1, 2]))) +
               (matrixA[0, 2] * ((matrixA[1, 0] * matrixA[2, 1]) - (matrixA[1, 1] * matrixA[2, 0])));

            Console.WriteLine();
            Console.WriteLine("The determinant of matrix A is {0}", determinantA);

            int determinantB = (matrixB[0, 0] * ((matrixB[1, 1] * matrixB[2, 2]) - (matrixB[2, 1] * matrixB[1, 2]))) -
                (matrixB[0, 1] * ((matrixB[1, 0] * matrixB[2, 2]) - (matrixB[2, 0] * matrixB[1, 2]))) +
               (matrixB[0, 2] * ((matrixB[1, 0] * matrixB[2, 1]) - (matrixB[1, 1] * matrixB[2, 0])));

            Console.WriteLine();
            Console.WriteLine("The determinant of matrix B is {0}", determinantB);


            if (determinantA > determinantB)
            {
                Console.WriteLine("\nThe determinant of matrix A is greater than that of matrix B.");
            }
            else if (determinantB > determinantA)
            {
                Console.WriteLine("\nThe determinant of matrix B is greater than that of matrix A.");
            }
            else
            {
                Console.WriteLine("\nThe determinants of the two matrices are equal.");
            }
        }
}