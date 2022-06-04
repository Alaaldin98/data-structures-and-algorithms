using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.QuickSort
{
    internal class Quick_Sort
    {
		public static void QuickSort(int[] arr, int left, int right)
		{
			if (left >= right) /*zero or one element in sublist*/
				return;
			int position = Partition(arr, left, right);
			QuickSort(arr, left, position - 1); /*Sort left sublist*/
			QuickSort(arr, position + 1, right);  /*Sort right sublist*/
		}

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    Swap(arr, i, low);
                    low++;
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        private static void Swap(int[] array, int i, int low)
        {
            int temp = array[i];
            array[i] = array[low];
            array[low] = temp;
        }
    }
}
