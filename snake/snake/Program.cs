using System;
using System.Collections.Generic;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            //p1.Draw();

            Point p2 = new Point(1, 4, '#');
            //p2.Draw();

            Point p3 = new Point(1, 6, '@');

            Point p4 = new Point(1, 8, '%');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //_________________

            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('*');
            charList.Add('#');
            charList.Add('#');

            //_________________

            foreach (int i in numList)
            {
                //Console.WriteLine(i);
            }


            for (int i = 0; i < charList.Count; i++)
            {
                //Console.WriteLine(charList[i]);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            for (int i = 0; i < charList.Count; i++)
            {
                p1.Draw();
                p2.Draw();
                p3.Draw();
                p4.Draw();
            }


            //Console.ReadLine();

        }

    }
}
