using System;
using System.Collections.Generic;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 27);

            HorizontalLines upLine = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, 78, 23, '+');
            VerticalLines leftLine = new VerticalLines(0, 23, 0, '+');
            VerticalLines rightLine = new VerticalLines(0, 23, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();
        }

    }
}
