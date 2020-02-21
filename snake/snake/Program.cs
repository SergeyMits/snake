using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.SetBufferSize(76, 20);

            Walls walls = new Walls(20, 10);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(18, 8, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    //snake.Draw();
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
                //Thread.Sleep(150);
                //snake.Move();
            }
             
        }

    }
}
