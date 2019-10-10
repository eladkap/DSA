using DSA;
using Sortings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main
{
    class Program
    {
        private static int[] GenerateArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
            return array;
        }


        private static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] A = GenerateArray(20, 1, 100);
            Sorting.MergeSort(A);
            ShowArray(A);
        }
    }
}
