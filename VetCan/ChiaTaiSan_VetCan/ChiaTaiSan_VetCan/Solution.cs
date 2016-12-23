using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChiaTaiSan_VetCan
{
    class Solution
    {
        private List<Toys> listToys;
        private List<Toys> DoChoiCuaAnh;

        public Solution(List<Toys> listToys)
        {
            this.listToys = listToys;
            this.DoChoiCuaAnh = new List<Toys>();

            Console.WriteLine("CHIA TAI SAN");
            Console.WriteLine("\r\n\r\n\r\n===========TRUONG HOP TOI UU VET CAN===========\r\n\r\n");
            Try(0);

            using (StreamReader sr=new StreamReader("ToiUu.txt"))
                Console.WriteLine(sr.ReadToEnd());
        }


        private int TongList(List<Toys> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
                s += list[i].GiaTri;
            return s;
        }


        //gần bằng 1 nữa
        private int ChonToiUu()
        {
            int GiaTriToiUu = TongList(listToys) / 2;
            return GiaTriToiUu;
        }


        private void InNghiem()
        {
            Console.WriteLine("-> Anh:");
            foreach (Toys t in DoChoiCuaAnh)
                Console.WriteLine(t.Name + ": " + t.GiaTri);
            

            Console.WriteLine("\r\n-> Em:");
            foreach (Toys to in listToys)
                if (to.DaChoNguoiAnh == 0)
                    Console.WriteLine(to.Name + ": " + to.GiaTri);

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
        }

        private int test = 9999999;
        private void Try(int i)
        {
            for (int j = 0; j <= 1; j++)
            {
                listToys[i].DaChoNguoiAnh = j;

                if (listToys[i].DaChoNguoiAnh == 1)
                    DoChoiCuaAnh.Add(listToys[i]);
                else DoChoiCuaAnh.Remove(listToys[i]);

                if (i == listToys.Count - 1)
                {

                //show all Trường hợp
                    /*if (DoChoiCuaAnh.Count != 0)
                        InNghiem();*/


                    //ghi file tối ưu, trường hợp tổng giá trị của anh gần bằng 1 nữa
                    if (TongList(DoChoiCuaAnh) - ChonToiUu() < test && TongList(DoChoiCuaAnh) >= ChonToiUu())
                    {
                        test = TongList(DoChoiCuaAnh) - ChonToiUu();
                        GhiFileTHtoiuu();
                    }
                }
                else Try(i + 1);
            }
        }


        private void GhiFileTHtoiuu()
        {
            using (StreamWriter sw = new StreamWriter("ToiUu.txt"))
            {
                sw.WriteLine("-> Anh:");
                foreach (Toys t in DoChoiCuaAnh)
                    sw.WriteLine(t.Name + ": " + t.GiaTri);
                sw.WriteLine("Tong gia tri: " + TongList(DoChoiCuaAnh));

                sw.WriteLine("\r\n-> Em:");
                foreach (Toys to in listToys)
                    if (to.DaChoNguoiAnh == 0)
                        sw.WriteLine(to.Name + ": " + to.GiaTri);
                sw.WriteLine("Tong gia tri: " + (TongList(listToys) - TongList(DoChoiCuaAnh)));

                sw.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
            }
        }

    }
}
