using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectConsoleApp1
{
    public class Rect
    {
        private int w, h;
        public Rect(int w, int h)
        {
            this.w = w;
            this.h = h;
        }
        public int Area()
        {
            return w * h;
        }
    }
}
