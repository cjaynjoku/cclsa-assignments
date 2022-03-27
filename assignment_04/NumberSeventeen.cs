using System;
class NumberSeventeen 
{
      static public int Partition(int[] arr, int left, int right) {
         int pivot;
         pivot = arr[left];
         while (true) {
            while (arr[left] < pivot) {
               left++;
            }

            while (arr[right] > pivot) {
               right--;
            }
            if (left < right) {
               int temp = arr[right];
               arr[right] = arr[left];
               arr[left] = temp;
            } else {
               return right;
            }
         }
      }
      static public void quickSort(int[] arr, int left, int right) {
         int pivot;
         if (left < right) {
            pivot = Partition(arr, left, right);
            if (pivot > 1) {
               quickSort(arr, left, pivot - 1);
            }  
            if (pivot + 1 < right) {
               quickSort(arr, pivot + 1, right);
            }
         }
      }
      static void Main(string[] args) {
         int[] arr = {4, 6, 3, 2, 1, 5, 11, 8, 4, 7};
         int n = 10, i;
         Console.WriteLine("Quick Sort");
         Console.Write("Initial array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         quickSort(arr, 0, 9);
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
      }
}
