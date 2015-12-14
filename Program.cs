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

            Point p2 = new Point();
            p2.Draw();

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


            Console.ReadLine();
        }

        

    }
}
