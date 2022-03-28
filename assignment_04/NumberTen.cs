using System;

internal class NumberTen
    {
        static void Main(string[] args)
        {
 	 int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
	 MostFrequentNumber();
	}

	private static void MostFrequentNumber(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;


                    }
                }
            }
            int count = 0;
            int mainCount = 0;
            int index = 0;
            int mainIndex = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    index = i - (count - 1);
                    if (count > mainCount)
                    {
                        mainCount = count;
                        mainIndex = index;

                    }
                }
                else
                {
                    count = 0;
                }

            }
            for (int i = mainIndex; i < mainIndex + mainCount + 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("(" + (mainCount + 1) + " times)");


        }

}