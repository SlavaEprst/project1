using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point()
        {

        }

        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;        
                
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sim = p.sim;

        }

        public void Move(int offset, direction direction)
        {
            if (direction == direction.RIGHT)
            {
                x = x + offset;
            }
            if (direction == direction.LEFT)
            {
                x = x - offset;
            }

            if (direction == direction.UP)
            {
                x = x + offset;
            }
            if (direction == direction.DOWN)
            {
                x = x - offset;
            }

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);

        }
    }
}
