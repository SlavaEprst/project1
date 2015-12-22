using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 8,'&');
            p1.Draw();

            Point p2 = new Point(1, 1,'#');
            p2.Draw();

            Point p3 = new Point(2, 7, '$');
            p3.Draw();

            Point p4 = new Point(5, 5, '^');
            p4.Draw();

            List<char> Sim = new List<char>();
            Sim.Add('@');
            Sim.Add('#');
            Sim.Add('$');
            Sim.Add('%');
            Sim.Add('&');

            foreach (char F in Sim)
            {
                Console.WriteLine(F);
            }


            List<Point> PointList = new List<Point>();
            PointList.Add(p1);
            PointList.Add(p2);
            PointList.Add(p3);
            PointList.Add(p4);

            HorizontLine line = new HorizontLine(5, 20, 5,20, '#');
            line.Drow();

            Console.ReadLine();
        }

        

    }
}
