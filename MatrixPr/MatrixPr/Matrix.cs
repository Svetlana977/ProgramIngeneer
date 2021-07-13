using System;

namespace MatrixPr
{
    class Matrix
    {

        public int i, j;

        public Matrix (int k,int l)
        {
            i = k;j = l;
        }

        public int sum()
        {
            return i+j;
        }

        static void Main(string[] args)
        {
            //sum(5, 6);
        }

    }
}
