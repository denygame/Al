using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin_ThamLam
{
    class Solution
    {
        List<int> kq, listNhap, tam;
        int k, n;

        public Solution(int n, int k, List<int> listNhap)
        {
            this.n = n;
            this.k = k;
            this.listNhap = listNhap;

            this.kq = new List<int>();
            this.tam = new List<int>();
        }


        private void TangDan()
        {
            for(int i=0;i<listNhap.Count;i++)
                for(int j=i;j<listNhap.Count;j++)
                    if (listNhap[i] < listNhap[j])
                    {
                        int temp = listNhap[i];
                        listNhap[i] = listNhap[j];
                        listNhap[j] = temp;
                    }
        }

        public void Xuly()
        {
            TangDan();
            int t = 0;
            int toiuu = 0;

            while (t <= n - k)
            {
                if (t == 0)
                {
                    for (int i = 0; i < t + k; i++)
                        kq.Add(listNhap[i]);
                    toiuu = kq.Max() - kq.Min();
                }
                else
                {
                    tam.Clear();
                    for (int i = t; i < t + k; i++)
                        tam.Add(listNhap[i]);

                    if ((tam.Max() - tam.Min()) < toiuu)
                    {
                        toiuu = tam.Max() - tam.Min();
                        kq.Clear();
                        kq = tam;
                    }
                }
                t++;
            }


            //in nghiem
            Console.WriteLine("Chon bo: ");
            for (int i = 0; i < k; i++)
                Console.Write(kq[i] + " ");
            Console.WriteLine("\r\n\r\n");
            Console.WriteLine(kq.Max() + " - " + kq.Min() + " = " + (kq.Max() - kq.Min()));

        }

    }
}
