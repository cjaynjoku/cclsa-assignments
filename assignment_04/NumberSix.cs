using System;

internal class NumberSix
    {
        static void Main(string[] args)
        {
	 maxSeqNotConsecutive();
	}

private static void maxSeqNotConsecutive()
        {
            int[] maxArray = new int[5] { 1, 2, 3, 4, 5 };
            int tempIndex;
            int[] result = new int[5];
            int counter = 0;

            for (int i = 0; i < maxArray.Length; i++)
            {
                int[] tempResult = new int[5];
                tempIndex = 1;

                for (int j = 1; j < maxArray.Length; j++)
                {
                    tempResult[0] = maxArray[i];
                    if (maxArray[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = maxArray[j];
                        tempIndex++;
                    }
                    else if (tempIndex > 1 && (maxArray[j] > tempResult[tempIndex - 2]) && (maxArray[j] < tempResult[tempIndex - 1]))
                    {
                        tempResult[tempIndex - 1] = maxArray[j];
                    }

                }
                if (counter < tempIndex)
                {
                    counter = tempIndex;
                    result = tempResult;
                }

            }
            for (int j = 0; j < counter; j++)
            {
                Console.WriteLine(result[j]);
            }
        }
}