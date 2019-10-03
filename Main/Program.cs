using DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> A = new Matrix<int>(5, 5, 1);
            Matrix<string> B = new Matrix<string>(3, 5, "$");
            Console.WriteLine(A);
            Console.WriteLine(B);
            A.SetValueAt(0, 0, 2);
            Console.WriteLine(A);

            Console.WriteLine("--");

            B.SetValueAt(0, 0, "%");
            foreach (var value in B)
            {
                Console.Write(value);
            }
        }
    }
}
