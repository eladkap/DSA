using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sortings;
using System;

namespace SortingUnitTests
{
    [TestClass]
    public class SortingTests
    {
        private int[] GenerateArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
            return array;
        }

        private bool IsSorted(int[] array)
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

        private void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public bool CheckSort(Action<int[]> sortFunc)
        {
            int[] A = GenerateArray(20, 1, 100);
            sortFunc(A);
            ShowArray(A);
            return IsSorted(A);
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            bool res = CheckSort(Sorting.BubbleSort);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestMaxSort()
        {
            bool res = CheckSort(Sorting.MaxSort);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestMergeSort()
        {
            bool res = CheckSort(Sorting.MergeSort);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestMerge()
        {
            int[] A = GenerateArray(10, 1, 100);
            int[] B = GenerateArray(6, 1, 100);
            Sorting.BubbleSort(A);
            Sorting.BubbleSort(B);
            int[] C = Sorting.Merge(A, B, 0, A.Length, 0, B.Length);
            ShowArray(C);

            Assert.IsTrue(IsSorted(C));
            int[] D = new int[A.Length + B.Length];
            int id = 0;
            for (int i = 0; i < A.Length; i++)
            {
                D[id] = A[i];
                id++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                D[id] = B[i];
                id++;
            }
            Sorting.BubbleSort(D);
            ShowArray(D);
            Assert.AreEqual(C.Length, D.Length);
            for (int i = 0; i < C.Length; i++)
            {
                Assert.AreEqual(C[i], D[i]);
            }
        }
    }
}
