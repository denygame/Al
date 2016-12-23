using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_VetCan
{
    class Item
    {
        private int choVaoTui;

        public int ChoVaoTui
        {
            get { return choVaoTui; }
            set { choVaoTui = value; }
        }

        

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //w là trọng lượng, v là giá trị
        private int w, v;

        public int V
        {
            get { return v; }
            set { v = value; }
        }

        public int W
        {
            get { return w; }
            set { w = value; }
        }


        public Item(string name,int w,int v)
        {
            this.name = name;
            this.w = w;
            this.v = v;
        }


    }
}
