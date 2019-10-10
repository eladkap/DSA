using DSA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DSAUnitTests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestMatrixInit()
        {
            try
            {
                Matrix<int> A = new Matrix<int>(5, 5, 1);
                Matrix<int> B = new Matrix<int>(5, 5);
            }
            catch (Exception e)
            {
                return;
            }
        }

        [TestMethod]
        public void TestMatrixGetValue()
        {
            Matrix<int> A = new Matrix<int>(5, 5, 10);
            Assert.AreEqual(A.GetValueAt(0, 0), 10);
        }

        [TestMethod]
        public void TestMatrixSetValue()
        {
            Matrix<int> A = new Matrix<int>(5, 5, 1);
            A.SetValueAt(3, 3, 5);
            Assert.AreEqual(A.GetValueAt(3, 3), 5);
        }

        [TestMethod]
        public void TestMatrixForLoop()
        {
            Matrix<int> A = new Matrix<int>(5, 3);
            int k = 1;
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    A.SetValueAt(i, j, k);
                    k++;
                }
            }
            k = 1;
            foreach (var value in A)
            {
                Assert.AreEqual(k, value);
                k++;
            }
        }

        [TestMethod]
        public void TestMatrixEqual()
        {
            Matrix<int> A = new Matrix<int>(5, 5);
            int k = 1;
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    A.SetValueAt(i, j, k);
                    k++;
                }
            }
            Matrix<int> B = new Matrix<int>(5, 5);
            k = 1;
            for (int i = 0; i < B.Rows; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    B.SetValueAt(i, j, k);
                    k++;
                }
            }
            Matrix<int> C = new Matrix<int>(5, 5, 1);
            Assert.AreEqual(A, B);
            Assert.AreNotEqual(A, C);
        }

        [TestMethod]
        public void TestMatrixCopy()
        {
            Matrix<string> A = new Matrix<string>(3, 3, "#");
            A.SetValueAt(0, 1, "hello");
            Matrix<string> B = A.Copy();
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    Assert.AreEqual(B.GetValueAt(i, j), A.GetValueAt(i, j));
                }
            }
        }

        [TestMethod]
        public void TestMatrixTranspose()
        {
            Random rand = new Random();
            Matrix<int> A = new Matrix<int>(4, 8, 1);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    int v = rand.Next(1, 100);
                    A.SetValueAt(i, j, v);
                }
            }
            Matrix<int> At = A.Transpose();
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    Assert.AreEqual(A.GetValueAt(i, j), At.GetValueAt(j, i));
                }
            }
        }
    }
}
