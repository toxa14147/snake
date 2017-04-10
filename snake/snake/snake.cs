﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction ;
       

        public Snake (point tail,int lenght,Direction _direction)
        {
            direction = _direction;
            plist = new List<point>();
            for (int i = 0; i < lenght; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }
        internal void Move()
        {
            point tail = plist.First();
            plist.Remove(tail);
            point head = GetNextpoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }

        private point GetNextpoint()
        {
            point head = plist.Last();
            point nextpoint = new point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }
    }
}
