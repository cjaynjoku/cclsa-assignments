using System;

internal class NumberSeven
    {
        static void Main(string[] args)
        {
	 NumberSeven();
	}

	 private static void NumberSeven()
        {
            Console.WriteLine("Enter the size of your array (N)");
            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of steps to check (K)");
            int K = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter your array element {0}", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int maxSum = 0;
            int startIndex = 0;
            for (int i = 0; i < (N - K) + 1; i++)
            {
                int temp = 0;
                int sum = 0;
                int tempIndex = 0;
                for (int j = i; j < (i + K); j++)
                {
                    tempIndex = j;
                    temp += arr[j];

                }
                sum = temp;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    startIndex = tempIndex - (K - 1);
                }
            }
            for (int i = startIndex; i < startIndex + K; i++)
            {
                Console.WriteLine(arr[i]);
            }
	}
}