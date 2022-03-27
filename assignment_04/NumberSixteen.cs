using System;

internal class NumberSixteen
    {
        static void Main(string[] args)
        {
	  int[] sortedArray = new int[] { 1, 2, 3, 4, 6, 7, 8, 9 };
          object myResult;

          myResult = BinarySearch(sortedArray, 10);
          Console.WriteLine(myResult);
	}
	public static object BinarySearch(int[] Array, int x)
        {

            int left = 0;
            int right = Array.Length - 1;

            while (left <= right)
            {
                int midpoint = (left + right) / 2;
                if (x < Array[midpoint])
                {
                    right = midpoint - 1;
                }
                else if (x > Array[midpoint])
                {
                    left = midpoint + 1;
                }
                else if (x == Array[midpoint])
                {
                    return ++midpoint;
                }

            }
            return "The number is not in the array";
        }

}