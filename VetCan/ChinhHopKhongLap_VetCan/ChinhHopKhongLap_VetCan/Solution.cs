using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinhHopKhongLap_VetCan
{
    class Solution
    {
        private int n, k;
        private int[] x, d; //mảng d dùng để đánh dấu

        public int[] D
        {
            get { return d; }
            set { d = value; }
        }

        public int[] X
        {
            get { return x; }
            set { x = value; }
        }



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
            this.x = new int[k];
            this.d = new int[n];    
            
        }

        private void InNghiem()
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
        }


        //lặp
        /*public void Try(int i)
        {
            for(int j=1;j<=n;j++)
            {
                if(d[i] != 1)
                {
                    x[i] = j;
                    d[i] = 1;
                    if (i == k - 1)
                        InNghiem();
                    else
                        Try(i + 1);
                    d[i] = 0;
                }
            }
        }*/


        //không lặp, không có trường hợp 1 bộ có 2 số giống nhau
        public void Try_CHKL(int i)
        {
            for (int j = 1, t = 0; j <= n; j++, t++)
            {
                if (d[t] != 1)
                {
                    x[i] = j;
                    d[t] = 1;
                    if (i == k - 1)
                        InNghiem();
                    else
                        Try_CHKL(i + 1);
                    d[t] = 0;
                }
            }
        }


    }
}
