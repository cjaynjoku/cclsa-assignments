using System;

internal class NumberNine
    {
        static void Main(string[] args)
        {
	 NumberNine();
	}
	private static void NumberNine()
        {
            int[] anArray = new int[7] { 4, 3, 1, 4, 2, 5, 8 };

            // Initial maximum sum and maximum ending is the first element in the array
            int maxSum = anArray[0];
            int maxEnding = anArray[0];
            int start = 0;
            int end = 0;
            int temp = 0;
            for (int i = 1; i < anArray.Length; i++)

            {

                maxEnding = Math.Max((maxEnding + anArray[i]), anArray[i]);
                if (maxEnding == anArray[i])
                {
                    start = i;
                }


                maxSum = Math.Max(maxEnding, maxSum);
                if (maxEnding < maxSum)
                {
                    end = i;
                }

            }
            Console.WriteLine(maxSum);
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(anArray[i]);
            }




        }
}