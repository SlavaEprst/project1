using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class snake:figure
    {
        public snake(Point teil, int light, direction direction)
        {
            pList = new List<Point>();

            for (int i = 0; i < light; i++)
            {
                Point p = new Point(teil);
                p.Move(i, direction);
                pList.Add(p);

            }
        }


    }
}
