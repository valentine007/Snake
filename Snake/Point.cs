using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;
        public int step;

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }

            step = step++;
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw(int color)
        {
            Console.SetCursorPosition(x, y);
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;   // устанавливаем цвет символа змеи
                Console.BackgroundColor = ConsoleColor.Black;     // устанавливаем цвет поля рамки
                //Console.ResetColor(); // сбрасываем в стандартный
            }
            if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;   // устанавливаем цвет символа змеи
                Console.BackgroundColor = ConsoleColor.Black;     // устанавливаем цвет поля рамки
            }
            if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;   // устанавливаем цвет символа еды
                Console.BackgroundColor = ConsoleColor.Black;     // устанавливаем цвет поля рамки
            }
            if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;   // устанавливаем цвет символа яда
                Console.BackgroundColor = ConsoleColor.Black;     // устанавливаем цвет поля рамки
            }
            if (color == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;   // устанавливаем цвет символа рамки
                Console.BackgroundColor = ConsoleColor.Blue;     // устанавливаем цвет поля рамки
            }
            Console.Write(symb);
        }

        public void Clear()
        {
            symb = ' ';
            Draw(0);
         }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }
    }
}

