using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class horisontalline
    {
        List<point> plist;
        public horisontalline(int xleft, int xright, int y, char sym)
        {
            plist = new List<point>();
            for (int x = xleft; x <= xright; x++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Drow()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}
