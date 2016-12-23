using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguoiDuLich_ThamLam
{
    class Solution
    {
        private int n;
        private int[,] d;
        private int[] daQua;
        private List<int> KQ;
        private int ChiPhi = 0;

        public Solution(int n, int[,] d)
        {
            this.n = n;
            this.d = d;
            this.KQ = new List<int>();
            this.daQua = new int[n];
        }

        public void runTL()
        {
            XuLy(0);
        }

        private void InNghiem()
        {
            Console.WriteLine("\r\n\r\n==================NGUOI DU LICH <THAM LAM>===================");
            for (int i = 0; i < n; i++)
                Console.Write(KQ[i] + " -> ");
            Console.WriteLine("1 - Chi phi: " + ChiPhi);
        }



        //xét đỉnh gần nhất add vào KQ, có thể không tối ưu



        private void XuLy(int xp) //truyền vào điểm xuất phát, đặt xp=0
        {
            //add vào đỉnh xuất phát nhập vào
            KQ.Add(xp + 1);
            daQua[0] = 1;

            int TongSoDinhDaDiQua = 1;
            int dinhGanNhat = 0;        //đỉnh có khoảng cách gần nhất


            while (TongSoDinhDaDiQua < n)
            {
                int min = 100000;

                for (int i = 0; i < n; i++)
                {
                    //Console.Write(d[xp, i] + " ");
                    if (d[xp, i] < min && d[xp, i] != -1 && daQua[i] == 0)
                    {
                        min = d[xp, i];
                        dinhGanNhat = i;
                    }
                }
                //Console.WriteLine();


                KQ.Add(dinhGanNhat + 1);
                ChiPhi += d[xp, dinhGanNhat];

                //in test
                Console.WriteLine((xp+1) + " -> " + (dinhGanNhat+1) + " = " + d[xp,dinhGanNhat]);


                daQua[dinhGanNhat] = 1;

                //reset while
                xp = dinhGanNhat;
                TongSoDinhDaDiQua++;
            }


            ChiPhi += d[dinhGanNhat, 0];    //cộng chi phí về đỉnh xp đấu tiên
            Console.WriteLine((xp + 1) + " -> 1 " + " = " + d[xp, 0]);


            InNghiem();

        }
    }
}
