using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToHopTEST_VetCan
{
    class Solution
    {
        private int[] x;
        private int n = 4, k = 2;
        private int[] mang = { 2, 5, 60, 7 };



        public Solution()
        {
            this.x = new int[k + 1];    //mảng bắt đầu từ 1
        }


        private void InNgiem()
        {
            for (int i = 1; i <= k; i++)
                Console.Write(mang[x[i] - 1] + " ");
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
