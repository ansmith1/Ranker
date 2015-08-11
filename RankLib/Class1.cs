using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankLib
{
    public static class RankUtil
    {
        private void swap(double[][] mtx, Tuple<int,int> c1, Tuple<int,int> c2)
        {
            int row1 = c1.Item1,
                row2 = c2.Item1,
                col1 = c1.Item2,
                col2 = c2.Item2;

            double temp = mtx[row1][col1];
            mtx[row1][col1] = mtx[row2][col2];
            mtx[row2][col2] = temp;

            return;
        }

        private void swap(double[][] mtx, int a, int b, bool row)
        {
            int dimToCheck = 1;
            if (row) dimToCheck = 0;
            if (a > mtx.GetLength(dimToCheck) || b > mtx.GetLength(dimToCheck)) 
                throw new IndexOutOfRangeException("One of the provided indices is larger than the dimension of the matrix!");

            if (row)
            {
                for (int i = 0; i < mtx.GetLength(0); i++)
                {
                    Tuple<int, int> c1 = new Tuple<int, int>(a, i),
                        c2 = new Tuple<int, int>(b, i);

                }
            }
            
        }

        public int rank(double[][] mtx)
        {
            //put matrix into rref and count rows?
            //jordan canonical form?
            return default(int); //TODO
        }
    }
}
