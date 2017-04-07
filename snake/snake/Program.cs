using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'*');
          
            p1.Draw();

            point p2 = new point(4, 5,'#');
            
            p2.Draw();
            //point p3 = new point(6, 8, '*');
            //point p4 = new point(7, 10, '#');
            char sym1 = '*';
            char sym2 = '#';
            List<char> sym = new List<char>();
            sym.Add(sym1);
            sym.Add(sym2);
            var a = sym[0];
            var b = sym[1];
            foreach(var i in sym)
            {
                Console.WriteLine(i);
            }
            //List<int> numlist = new List<int>();
            //numlist.Add(0);
            //numlist.Add(1);
            //numlist.Add(2);
            //int x = numlist[0];
            //int y = numlist[1];
            //int z = numlist[2];
            //foreach(int i in numlist )
            //{
            //    Console.WriteLine(i);
            //}
            //numlist.RemoveAt(0);
            //List<point> plist = new List<point>();
            //plist.Add(p1);
            //plist.Add(p2);
            //Console.ReadLine();
            //List<point> plist = new List<point>();
            //plist.Add(p1);
            //plist.Add(p2);
            //plist.Add(p3);
            //plist.Add(p4);
            //point p = plist[0];
            //point a = plist[1];
            //point e = plist[2];
            //foreach(point i in plist)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
       
    }
}
