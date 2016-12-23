using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Knapsack_VetCan
{
    class Solution
    {
        private List<Item> listItem;
        private Bag bag;
        private int Vmax;   //giá trị lớn nhất

        public Solution(List<Item> listItem,Bag bag)
        {
            this.listItem = listItem;
            this.bag = bag;
            this.Vmax = 0;
        }

        private void InNghiem()
        {
            foreach (Item i in bag.ListItemsInBag)
                if (i.ChoVaoTui == 1)
                    Console.WriteLine(i.Name + " " + i.W + " " + i.V);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
        }



        //thuật toán vét cạn bài cái túi <knapsack>
        public void Try(int i)
        {
            for (int j = 0; j <= 1; j++)
            {
                listItem[i].ChoVaoTui = j;
                if (listItem[i].ChoVaoTui == 1)
                    bag.ThemItem(listItem[i]);
                else
                    bag.XoaItem(listItem[i]);
                if (i == listItem.Count - 1)
                {
                    if (bag.Wmax1 >= bag.TongTrongLuong() && bag.TongGiaTri() != 0) //dùng để in tất cả các nghiệm
                    {
                        InNghiem();
                    }
                    if(bag.Wmax1>=bag.TongTrongLuong() && bag.TongGiaTri()>Vmax)    //ghi trường hợp tối ưu xuống file
                    {
                        Vmax = bag.TongGiaTri();
                        GhiFileTHtoiuu();
                    }
                }
                else
                    Try(i + 1);
            }
        }



        private void GhiFileTHtoiuu()
        {
            using (StreamWriter sw =new StreamWriter("textfile.txt"))
            {
                foreach (Item i in bag.ListItemsInBag)
                    if (i.ChoVaoTui == 1)
                        sw.WriteLine(i.Name + " " + i.W + " " + i.V);
                sw.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
            }
        }

    }
}
