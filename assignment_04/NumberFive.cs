using System;

internal class NumberFive
    {
        static void Main(string[] args)
        {
	 int[] maxSeqArray = new int[] { 1, 1, 2, 3, 2, 3, 4, 5, 6, 1, 1, 1, 1, 1 };
            MaxSequence(maxSeqArray);
	}


	private static void MaxSequence(int[] Array)
        {
            int initialIndex = 0;
            int maxSeqIndex = 0;
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i + 1] == Array[i] + 1)
                {
                    count++;
                    initialIndex = i - (count - 1);
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxSeqIndex = initialIndex;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = maxSeqIndex; i < maxSeqIndex + maxCount + 1; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
}