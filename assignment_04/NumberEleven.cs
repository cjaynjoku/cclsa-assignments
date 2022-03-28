using System;

internal class NumberEleven
    {
        static void Main(string[] args)
        {
 	 int[] anArray = new int[7] { 4, 3, 1, 4, 2, 5, 8 };
	 SubSeqWithSumS();
	}
	 private static void SubSeqWithSumS(int[] arr)
        {
            int sum = Int32.MinValue;
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int S = Int32.Parse(Console.ReadLine());
            for (int left = 0; left < arr.Length; left++)
            {
                currentSum = 0;
                for (int right = left; right < arr.Length; right++)
                {
                    currentSum += arr[right];
                    if (currentSum == S)
                    {
                        startIndex = left;
                        endIndex = right;
                        break;
                    }


                }
                sum = currentSum;
                if (sum == S)
                {
                    break;
                }
            }
            for (int i = startIndex; i < endIndex + 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
}