using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorisontalLine
    {
        List<point> plist;
        public HorisontalLine(int yLeft,int yRight,int x,char sym)
        {
            plist = new List<point>();
            for(int y = yLeft; y <= yRight; y++) {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Drow()
        {
            foreach(point p in plist)
            {
                p.Draw();
            }
        }
    }
}
