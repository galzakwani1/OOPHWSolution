using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
    public class Rectangle
    {
        private int width=3;
        private int height=6;
        public int Area()
        {
            return width * height;
        }
        public int Area(int width, int height)
        {
            return width * height;
        }
    }
}
