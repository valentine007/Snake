using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class GameProcess
    {
        public void StartGame(int width, int height)
        {
            //Console.SetBufferSize(80, 25);  // задаем размер окна, убираем возможность перемотки
            Console.SetWindowSize(width, height);

            int score = 0;
            int N = 0;       //счетчик для увеличения скорости.
            int NN = 100;      //начальная задержка(скокрость) змейки
            int countEat = 0;

            Messages.GameStart();
            Thread.Sleep(1000);
            Console.Clear();

            Walls walls = new Walls(width, height);
            walls.Draw(4);

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw(1);

            FoodCreator foodCreator = new FoodCreator(width, height, '$');
            Point food = foodCreator.CreateFood();
            food.Draw(2);

            ToxicCreator toxicCreator = new ToxicCreator(width, height, 'O');
            Point toxic = toxicCreator.CreateToxic();
            toxic.Draw(3);


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Messages.GameOver();
                    break;
                    
                }

                if (snake.Eat(food))
                {

                    food = foodCreator.CreateFood();
                    food.Draw(2);
                    score=score+3;        //считаем очки за сьеденную вкусняшку
                    countEat = countEat + 1;
                    if ((countEat % 2) == 0)        // каждые две сьеденных вкусняшки добавляем Йаду...
                    {
                        toxic = toxicCreator.CreateToxic();
                        toxic.Draw(3);
                     }
                }
                else if (snake.noEat(toxic))
                {
                    toxic = toxicCreator.CreateToxic();
                    toxic.Draw(3);
                    score=score-2;        //отнимаем очки за сьеденный яд

                }
                else
                {
                    snake.Move();
                }

                if ((N % 100) == 0)         //каждые 100 шагов увеличиваем скорость
                {
                    NN = NN - 5;
                }

                Thread.Sleep(NN);


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                N++;            //считаем количество шагов
            }
            Messages.GameOver();
            Thread.Sleep(600);
            AddScore AddScore = new AddScore(score);        //добавляем статистику по игроку
            AddScore.AddUser();

        }
    }
}
