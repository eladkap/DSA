using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public static class Sorting
    {
        private static void Swap(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }

        private static void Bubble(int[] array, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                }
            }
        }

        public static void BubbleSort(int[] array)
        {
            for (int k = array.Length - 1; k >= 0 ; k--)
            {
                Bubble(array, 0, k);
            }
        }

        private static int GetMax(int[] array, int startIndex, int endIndex)
        {
            int maxValue = array[0];
            int maxIndex = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static void MaxSort(int[] array)
        {
            for (int k = array.Length - 1;  k >= 0;  k--)
            {
                int maxIndex = GetMax(array, 0, k);
                Swap(array, maxIndex, k);
            }
        }

        public static int[] Merge(int[] A, int[] B, int sa, int ea, int sb, int eb)
        {
            int[] C = new int[ea - sa + eb - sb];
            int ia = sa;
            int ib = sb;
            int ic = 0;
            while (ia < ea && ib < eb)
            {
                if (A[ia] <= B[ib]){
                    C[ic] = A[ia];
                    ia++;
                    ic++;
                }
                else
                {
                    C[ic] = B[ib];
                    ib++;
                    ic++;
                }
            }
            while (ia < ea)
            {
                C[ic] = A[ia];
                ia++;
                ic++;
            }
            while (ib < eb)
            {
                C[ic] = B[ib];
                ib++;
                ic++;
            }
            return C;
        }

        public static void MergeSort(int[] array)
        {
            int[] MergeSortAux(int[] arr, int startIndex, int endIndex, int n)
            {
                if (n == 1)
                {
                    return new int[] { arr[startIndex]};
                }
                int[] leftArray = MergeSortAux(arr, startIndex, endIndex / 2, n / 2);
                int[] rightArray = MergeSortAux(arr, endIndex / 2, endIndex, n - n / 2);
                int[] mergedArray = Merge(leftArray, rightArray, startIndex, endIndex / 2, endIndex / 2, endIndex);
                return mergedArray;
            }
            array = MergeSortAux(array, 0, array.Length, array.Length);
        }

        public static int Select(int[] array , int k)
        {
            int index = 0;
            return index;
        }

        public static void Partition(int[] array, int pivot)
        {

        }

        public static void QuickSort(int[] array)
        {

        }

        public static void CountingSort(int[] array)
        {

        }

        public static void RadixSort(int[] array)
        {

        }

    }
}
