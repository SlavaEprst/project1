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
            int x1 = 1;
            int y1 = 3;
            char sim1 = '*';
            int x2 = 3;
            int y2 = 5;
            char sim2 = '#';

            Draw(x1, y1, sim1);
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sim)
        {

Console.SetCursorPosition(x, y);
           Console.Write(sim);
            }

    }
}
