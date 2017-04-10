using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
           Console.SetBufferSize(80, 25);
           

            //отрисовка рамки
            verticalline line = new verticalline(0,24,0,'+');
            line.Drow();
            verticalline line1 = new verticalline(0, 24, 78, '+');
            line1.Drow();
            horisontalline line2 = new horisontalline(0, 78,24, '+');
            line2.Drow();
            horisontalline line3 = new horisontalline(0, 78, 0, '+');
            line3.Drow();

            //отрисовка точек
            point p = new point(1, 3, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Console.ReadLine();
        }
       
    }
}
