using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_VetCan
{
    class Bag
    {
        private int Wmax;

        private List<Item> listItemsInBag;

        internal List<Item> ListItemsInBag
        {
            get { return listItemsInBag; }
            set { listItemsInBag = value; }
        }



        public int Wmax1
        {
            get { return Wmax; }
            set { Wmax = value; }
        }


        public Bag(int Wmax)
        {
            this.Wmax = Wmax;
            this.listItemsInBag = new List<Item>(); //khai báo list
        }

        public void ThemItem(Item i)
        {
            listItemsInBag.Add(i);
        }

        public void XoaItem(Item i)
        {
            foreach(Item o in listItemsInBag)
                if(i.Name.Equals(o.Name)==true)
                {
                    listItemsInBag.Remove(i);
                    break;
                }
        }


        public int TongTrongLuong()
        {
            int s = 0;
            foreach (Item i in listItemsInBag)
                if(i.ChoVaoTui==1)
                    s += i.W;
            return s;
        }

        public int TongGiaTri()
        {
            int v = 0;
            foreach (Item i in listItemsInBag)
                if (i.ChoVaoTui == 1)
                    v += i.V;
            return v;
        }

    }
}
