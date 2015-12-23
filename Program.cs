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

            HorizontLine line = new HorizontLine(1, 50, 1,20, '+');
            line.Drow();

            Point p = new Point(6, 6, '*');
         

            snake snake = new snake(p, 7, direction.DOWN);
            snake.Drow();


            Console.ReadLine();
        }

        

    }
}
