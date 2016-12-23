using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiaTaiSan_ThamLam
{
    class Solution
    {
        private List<Toys> listToys;
        private List<Toys> DoChoiCuaAnh;
        private List<Toys> DoChoiCuaEm;

        public Solution(List<Toys> listToys)
        {
            this.listToys = listToys;
            DoChoiCuaAnh = new List<Toys>();
            DoChoiCuaEm = new List<Toys>();

            GiamDanListToys(listToys);  //sắp xếp giảm dần theo giá trị

            Console.WriteLine("=============LIST QUA DA SORT=============");
            for (int i = 0; i < listToys.Count; i++)
                Console.WriteLine(listToys[i].Name + ": " + listToys[i].GiaTri);

            Console.WriteLine("\r\n\r\n\r\n==========KET QUA CHIA THAM LAM===========");
            Xuly();
        }


        private void InNghiem()
        {
            Console.WriteLine("\r\n => ANH: \r\n");
            for (int i = 0; i < DoChoiCuaAnh.Count; i++)
                Console.WriteLine(DoChoiCuaAnh[i].Name + ": " + DoChoiCuaAnh[i].GiaTri);
            Console.WriteLine("Tong gia tri: " + TongList(DoChoiCuaAnh));


            Console.WriteLine("\r\n\r\n => EM: \r\n");
            for (int i = 0; i < DoChoiCuaEm.Count; i++)
                Console.WriteLine(DoChoiCuaEm[i].Name + ": " + DoChoiCuaEm[i].GiaTri);
            Console.WriteLine("Tong gia tri: " + TongList(DoChoiCuaEm));
        }

        private int TongList(List<Toys> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
                s += list[i].GiaTri;
            return s;
        }

        //Sort giảm dần
        private void GiamDanListToys(List<Toys> l)
        {
            for (int i = 0; i < l.Count; i++)
                for (int j = i; j < l.Count; j++)
                    if (l[i].GiaTri < l[j].GiaTri)
                    {
                        int temp = l[i].GiaTri;
                        l[i].GiaTri = l[j].GiaTri;
                        l[j].GiaTri = temp;
                    }
        }

        //tham lam
        public void Xuly()
        {
            int i = 0;
            int tong = listToys.Count;
            while (i < tong)
            {
                if (TongList(DoChoiCuaAnh) == 0 && TongList(DoChoiCuaEm) == 0)
                {
                    //add đồ lớn nhất cho thằng anh
                    DoChoiCuaAnh.Add(listToys[i]);   
                    i++;
                    continue;
                }

                if (TongList(DoChoiCuaEm) < TongList(DoChoiCuaAnh))
                    DoChoiCuaEm.Add(listToys[i]);
                else
                    DoChoiCuaAnh.Add(listToys[i]);

                i++;
            }
            InNghiem();
        }

    }
}
