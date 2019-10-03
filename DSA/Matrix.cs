using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Matrix<T> : IEnumerator, IEnumerable
    {
        private int rows;
        private int cols;
        private T[,] mat;
        private int currRow = 0;
        private int currCol = -1;

        public T Current
        {
            get
            {
                return mat[currRow, currCol];
            }
        }

        public Matrix(int rows, int cols, T data=default(T))
        {
            this.rows = rows;
            this.cols = cols;
            mat = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mat[i, j] = data;
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    s += mat[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }

        public T GetValueAt(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                throw new IndexOutOfRangeException();
            }
            return mat[row, col];
        }

        public void SetValueAt(int row, int col, T value)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                throw new IndexOutOfRangeException();
            }
            mat[row, col] = value;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
           currCol++;
           if (currCol == cols)
           {
               currCol = 0;
               currRow++;
               if (rows == currRow)
               {
                   return false;
               }
           }
           return true;
        }
   
        public void Reset()
        {
            currRow = 0;
            currCol = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
