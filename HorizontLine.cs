using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HorizontLine:figure
    {
  

        public HorizontLine(int xLe, int xRi, int yLe, int yRi, char sim)
        {
            pList = new List<Point>();
          
            for (int y = yLe; y <= yRi; y++)
            {
                Point p2 = new Point(xLe, y,  sim);
                pList.Add(p2);
                Point p3 = new Point(xRi, y, sim);
                pList.Add(p3);
            }
  for (int x = xLe; x <= xRi; x++)
            {
                Point p = new Point(x, yLe, sim);
                pList.Add(p);
                Point p1 = new Point(x, yRi, sim);
                pList.Add(p1);
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

