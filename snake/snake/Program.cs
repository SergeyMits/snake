using System;
using System.Collections.Generic;
using System.Threading;

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
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.Drow();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(150);
                snake.Move();
            }
             
        }

    }
}
