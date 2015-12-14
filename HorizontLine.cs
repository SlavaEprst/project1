using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HorizontLine
    {
        List<Point> pList;

        public HorizontLine(int xLe, int xRi, int y, char sim)
        {
            pList = new List<Point>();
            for (int x = xLe; x <= xRi; x++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
            public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }

        }

        
        }

    }

