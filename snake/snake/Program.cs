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
            point p = new point(1,3,'*');
          
            //p1.Draw();

            point p2 = new point(4, 5,'#');

            //p2.Draw();
           Console.SetBufferSize(80, 36);
           verticalline line = new verticalline(0,35,78,'+');
            line.Drow();
            verticalline line1 = new verticalline(0, 35, 0, '+');
            line1.Drow();
            horisontalline line2 = new horisontalline(0, 78, 35, '+');
            line2.Drow();
            horisontalline line3 = new horisontalline(0, 78, 0, '+');
            line3.Drow();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine();
        }
       
    }
}
