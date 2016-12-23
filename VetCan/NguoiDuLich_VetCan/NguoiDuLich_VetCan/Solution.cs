using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NguoiDuLich_VetCan
{
    class Solution
    {
        private int[,] d;   //mảng chi phí
        private int n;
        private int[] daQua;    //mảng duyệt
        private int[] X, phanTu;
        private int TongChiPhi = 0, ChiPhi = 0; //tongchiphi là biến xét, chiphi là biến show

        public Solution(int n, int[,] d)
        {
            this.n = n;
            this.d = d;
            this.daQua = new int[n];
            this.X = new int[n];
            this.phanTu = new int[n];

            //sinh các phần tử là thành phố
            for (int i = 0; i < n; i++)
                phanTu[i] = i + 1;
        }


        
        public void ShowAll()
        {
            X[0] = 1;   //điểm bắt đầu là 1

            Console.WriteLine("=================ALL TH VET CAN===================");
            Try_VC(1);  //i=1 => X[1] nghĩa là điểm thứ 2 

            
            Console.WriteLine("\r\n\r\n\r\n=================TH VET CAN TOI UU===================");
            Try_VCTU(1);
            using (StreamReader sr = new StreamReader("TUVC.txt"))
                Console.WriteLine(sr.ReadToEnd());

            //Console.WriteLine(MinInD());
            //Console.WriteLine(TongChiPhi);

            Console.WriteLine("\r\n\r\n\r\n=================ALL TH NHANH CAN====================");
            Try_NhanhCan(1);


            Console.WriteLine("\r\n\r\n\r\n================TH NHANH CAN TOI UU==================");
            using (StreamReader sr = new StreamReader("TUNC.txt"))
                Console.WriteLine(sr.ReadToEnd());
        }






        private void GhiFileTHtoiuu(string tenfile)
        {
            using (StreamWriter sw = new StreamWriter(tenfile))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.Write(X[i] + " -> ");
                }
                sw.Write("1 - Chi Phi: " + ChiPhi);
                sw.WriteLine();
                sw.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
            }
        }



        //VÉT CẠN




        private void InNghiem()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(X[i] + " -> ");
            }
            Console.Write("1 - Chi Phi: " + ChiPhi);
            Console.WriteLine();
        }


        /*show hết các tập hợp ra <bằng vét cạn>. Là hoán vị của tổng tp trừ đi 1
        VD: Có 5 thành phố, ta bắt đầu đi từ thành phố 1, vậy phải hoán vị 4 thành phố còn lại*/
        private void Try_VC(int i)
        {
            for (int j = 1; j < n; j++)
            {
                if (daQua[j] == 0)
                {
                    X[i] = phanTu[j];
                    daQua[j] = 1;
                    TongChiPhi += d[X[i - 1] - 1, phanTu[j] - 1];
                    if (i == n - 1)
                    {
                        ChiPhi = TongChiPhi;
                        ChiPhi += d[X[i] - 1, 0];
                        InNghiem();
                    }
                    else Try_VC(i + 1);

                    daQua[j] = 0;
                    TongChiPhi = TongChiPhi - d[X[i - 1] - 1, phanTu[j] - 1];

                }
            }
        }


        //dùng vét cạn để show trường hợp tối ưu. Nhược điểm: Xét rất nhiều
        private void Try_VCTU(int i)
        {
            for (int j = 1; j < n; j++)
            {
                if (daQua[j] == 0)
                {
                    X[i] = phanTu[j];
                    daQua[j] = 1;
                    TongChiPhi += d[X[i - 1] - 1, phanTu[j] - 1];
                    if (i == n - 1)
                    {
                        if (ChiPhi > TongChiPhi + d[X[i] - 1, 0])
                        {
                            ChiPhi = TongChiPhi;
                            ChiPhi += d[X[i] - 1, 0];
                            GhiFileTHtoiuu("TUVC.txt");
                        }
                    }
                    else Try_VCTU(i + 1);

                    daQua[j] = 0;
                    TongChiPhi = TongChiPhi - d[X[i - 1] - 1, phanTu[j] - 1];
                }
            }
        }









        //NHÁNH CẬN



        //tìm min trong mảng chi phí d, min khác -1 tức là vô cùng <không có đường đi>
        private int MinInD()
        {
            int min=99999999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (min > d[i, j] && d[i, j] != -1)
                        min = d[i, j];
            }
            return min;
        }


        private int ChiPhiToiUu = 999999;   //tìm chi phí tối ưu tức là chi phí nhỏ nhất

        private void Try_NhanhCan(int i)
        {
            int test = 0;   //biến test để bỏ trường hợp
            for(int j=1;j<n;j++)
            {
                if(daQua[j]==0)
                {
                    X[i] = phanTu[j];
                    daQua[j] = 1;
                    TongChiPhi += d[X[i - 1] - 1, phanTu[j] - 1];

                    if (i == n - 1)
                    {
                        ChiPhi = TongChiPhi + d[X[i] - 1, 0];
                        if (ChiPhi < ChiPhiToiUu)
                        {
                            ChiPhiToiUu = ChiPhi;
                            GhiFileTHtoiuu("TUNC.txt");
                            InNghiem();
                        }
                    }
                    else
                    {
                        /* ta còn phải đi qua n-i+1 đoạn đường nữa, gồm n-i thành phố còn lại và đoạn quay lại thành phố 1. 
                        Do chi phí mỗi một trong n-i+1 đoạn còn lại không nhỏ hơn MinInD()*/
                        test = TongChiPhi + (n - i + 1) * MinInD();

                        if (test < ChiPhiToiUu)
                            Try_NhanhCan(i + 1);
                    }

                    daQua[j] = 0;
                    TongChiPhi = TongChiPhi - d[X[i - 1] - 1, phanTu[j] - 1];
                }
            }
        }

    }
}
