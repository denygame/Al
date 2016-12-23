using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToHop_VetCan
{
    class Solution
    {
        private int[] x;

        public int[] X
        {
            get { return x; }
            set { x = value; }
        }

        private int n, k;

        public int K
        {
            get { return k; }
            set { k = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }



        public Solution(int n, int k)
        {
            this.n = n;
            this.k = k;
            this.x = new int[k + 1];    //mảng bắt đầu từ 1
        }


        private void InNgiem()
        {
            for (int i = 1; i <= k; i++)
                Console.Write(x[i] + " ");
            Console.WriteLine();
        }



        public void Try(int i)
        {
            for (int j = x[i - 1] + 1; j <= n - k + i; j++)
            {
                x[i] = j;
                if (i == k)             // mảng start từ 1 nên không -1
                    InNgiem();
                else
                    Try(i + 1);
            }
        }


    }
}
