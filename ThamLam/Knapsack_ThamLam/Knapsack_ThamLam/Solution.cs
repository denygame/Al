using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Knapsack_ThamLam
{
    class Solution
    {
        private List<Item> listItem;
        private Bag bag;

        public Solution(List<Item> listItem,Bag bag)
        {
            this.listItem = listItem;
            this.bag = bag;

            bag.ListItemsInBag.Clear();
        }

        private void InNghiem()
        {
            foreach (Item i in bag.ListItemsInBag)
                Console.WriteLine(i.Name + " " + i.W + " " + i.V);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");
        }





        public void ThamLam()
        {
            listItem.Sort();    //sắp xếp v giảm dần

            
            for (int i = 0; i < listItem.Count;i++ )
                if (listItem[i].W + bag.TongTrongLuong() <= bag.Wmax1)
                    bag.ThemItem(listItem[i]);

            InNghiem();
        }









       

    }
}
