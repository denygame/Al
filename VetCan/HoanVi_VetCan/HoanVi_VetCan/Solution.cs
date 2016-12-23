using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanVi_VetCan
{
    class Solution
    {
        private int[] phanTu, X, danhdau;
        private int n;

        public Solution(int n, int[] phanTu)
        {
            this.n = n;
            this.phanTu = phanTu;
            this.X = new int[n];
            this.danhdau = new int[n];
        }

        private void InNghiem()
        {
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();
        }


        //phải có mảng đánh dấu các vị trí đã qua
        public void Try(int i)
        {
            for (int j = 0; j < n; j++)
            {
                if (danhdau[j] == 0)
                {
                    X[i] = phanTu[j];
                    danhdau[j] = 1;
                    if (i == n - 1)
                        InNghiem();
                    else
                        Try(i + 1);
                    danhdau[j] = 0;
                }
            }
        }

    }
}
