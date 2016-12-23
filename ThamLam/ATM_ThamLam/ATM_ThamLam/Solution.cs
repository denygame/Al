using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ThamLam
{
    class Solution
    {
        private long soTien;
        private int[] menhGia;


        public Solution(long soTien, int[] menhGia)
        {
            this.soTien = soTien;
            this.menhGia = menhGia;
        }


        private void Print(int soTo,int GiaTriToTien)
        {
            Console.WriteLine(soTo + " to: " + GiaTriToTien / 1000 + "K");
        }

        public void XuLyThamLam()
        {
            MoneyBank mon = new MoneyBank(menhGia);
            mon.GiamDan();


            int i = 0;

            while (soTien > 0)
            {
                if (soTien < menhGia[menhGia.Length - 1])
                {
                    Console.WriteLine("=> Khong co to tien co menh gia " + soTien + " dong! Sorry.");
                    break;
                }


                if (soTien / menhGia[i] != 0)
                {
                    //soTo = intsoTien / menhGia[i];
                    Print((int)(soTien / menhGia[i]), menhGia[i]);
                    soTien = soTien % menhGia[i];
                }
                else i++;
            }
        }
    }
}
