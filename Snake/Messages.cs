using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Messages
    {
        public static void GameOver()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t╔═══╦══╦╗  ╔╦═══╗");
            Console.WriteLine("\t\t\t║╔══╣╔╗║║  ║║╔══╝");
            Console.WriteLine("\t\t\t║║╔═╣╚╝║╚╗╔╝║╚══╗");
            Console.WriteLine("\t\t\t║║╚╗║╔╗║╔╗╔╗║╔══╝");
            Console.WriteLine("\t\t\t║╚═╝║║║║║╚╝║║╚══╗");
            Console.WriteLine("\t\t\t╚═══╩╝╚╩╝  ╚╩═══╝");
            Console.WriteLine();
            Console.WriteLine("\t\t\t╔══╦╗╔╦═══╦═══╦╗");
            Console.WriteLine("\t\t\t║╔╗║║║║╔══╣╔═╗║║");
            Console.WriteLine("\t\t\t║║║║║║║╚══╣╚═╝║║");
            Console.WriteLine("\t\t\t║║║║╚╝║╔══╣╔╗╔╩╝");
            Console.WriteLine("\t\t\t║╚╝╠╗╔╣╚══╣║║║╔╗");
            Console.WriteLine("\t\t\t╚══╝╚╝╚═══╩╝╚╝╚╝");
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void GameStart()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.SetCursorPosition(3, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t    ╔═══╗ ╔══╦ ╔╗  ╔╗ ╔═══╗");
            Console.WriteLine("\t\t\t    ║╔══╝ ║╔╗║ ║║  ║║ ║╔══╝");
            Console.WriteLine("\t\t\t    ║║╔═╗ ║╚╝║ ║╚╗╔╝║ ║╚══╗");
            Console.WriteLine("\t\t\t    ║║╚╗║ ║╔╗║ ║╔╗╔╗║ ║╔══╝");
            Console.WriteLine("\t\t\t    ║╚═╝║ ║║║║ ║║╚╝║║ ║╚══╗");
            Console.WriteLine("\t\t\t    ╚═══╝ ╩╝╚╝ ╚╝  ╚╝ ╚═══╝");
            Console.WriteLine();
            Console.WriteLine("\t\t\t╔══╗ ╔════╗ ╔══╦ ╔═══╗ ╔════╗ ╔╗");
            Console.WriteLine("\t\t\t║╔═╝ ╚═╗╔═╝ ║╔╗║ ║╔═╗║ ╚═╗╔═╝ ║║");
            Console.WriteLine("\t\t\t║╚═╗   ║║   ║╚╝║ ║╚═╝║   ║║   ║║");
            Console.WriteLine("\t\t\t╚═╗║   ║║   ║╔╗║ ║╔╗╔╝   ║║   ╚╝");
            Console.WriteLine("\t\t\t╔═╝║   ║║   ║║║║ ║║║║    ║║   ╔╗");
            Console.WriteLine("\t\t\t╚══╝   ╚╝   ╩╝╚╝ ╚╝╚╝    ╚╝   ╚╝");
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Welcome()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.SetCursorPosition(3, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            Console.WriteLine("\t\t███████████████████████████████████████████████");
            Console.WriteLine("\t\t█ ███ █───█─███────█────█─███─█───████   █    █");
            Console.WriteLine("\t\t█ ███ █─███─███─██─█─██─█──█──█─███████ ██ ██ █");
            Console.WriteLine("\t\t█ █ █ █───█─███─████─██─█─█─█─█───█████ ██ ██ █");
            Console.WriteLine("\t\t█     █─███─███─██─█─██─█─███─█─███████ ██ ██ █");
            Console.WriteLine("\t\t██ █ ██───█───█────█────█─███─█───█████ ██    █");
            Console.WriteLine("\t\t███████████████████████████████████████████████");
            Console.WriteLine("\t\t\t     █    █────█─███─█   █ █");
            Console.WriteLine("\t\t\t     █ ████─██─█──█──█ ███ █");
            Console.WriteLine("\t\t\t     █ █  █────█─█─█─█   █ █");
            Console.WriteLine("\t\t\t     █ ██ █─██─█─███─█ █████");
            Console.WriteLine("\t\t\t     █    █─██─█─███─█   █ █");
            Console.WriteLine("\t\t\t     ███████████████████████");
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Goodbye()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t████████████████████████████████████████");
            Console.WriteLine("\t\t█────█────█────█────██────██──█──█───█─█");
            Console.WriteLine("\t\t█─████─██─█─██─█─██──█─██──██───██─███─█");
            Console.WriteLine("\t\t█─█──█─██─█─██─█─██──█────████─███───█─█");
            Console.WriteLine("\t\t█─██─█─██─█─██─█─██──█─██──███─███─█████");
            Console.WriteLine("\t\t█────█────█────█────██────████─███───█─█");
            Console.WriteLine("\t\t████████████████████████████████████████");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.WriteLine("\n\n\n\n");
        }

        public static void Snake()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t███████████████████████████████");
            Console.WriteLine("\t\t\t██─────█─███─█────█─██─██────██");
            Console.WriteLine("\t\t\t██─█████──██─█─██─█─█─███─█████");
            Console.WriteLine("\t\t\t██─────█───█─█─██─█───███────██");
            Console.WriteLine("\t\t\t██████─█─█───█────█─██──█─█████");
            Console.WriteLine("\t\t\t██─────█─██──█─██─█─██──█────██");
            Console.WriteLine("\t\t\t███████████████████████████████");
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Score()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t████████████████████████████████");
            Console.WriteLine("\t\t\t██─────█─██─██─────█─────█────██");
            Console.WriteLine("\t\t\t██─█████─█─███─███─█─███─█─█████");
            Console.WriteLine("\t\t\t██─────█───███─███─█─────█────██");
            Console.WriteLine("\t\t\t██████─█─██──█─███─█─█─███─█████");
            Console.WriteLine("\t\t\t██─────█─██──█─────█─██──█────██");
            Console.WriteLine("\t\t\t████████████████████████████████");
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Rules()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t██████████████████████");
            Console.WriteLine("\t\t\t█────█─█─█─███───█───█");
            Console.WriteLine("\t\t\t█─██─█─█─█─███─███─███");
            Console.WriteLine("\t\t\t█────█─█─█─███───█───█");
            Console.WriteLine("\t\t\t█─█─██─█─█─███─█████─█");
            Console.WriteLine("\t\t\t█─█─██───█───█───█───█");
            Console.WriteLine("\t\t\t██████████████████████");
            Console.ResetColor();
            Console.Write(" 1. ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$ ");
            Console.ResetColor();
            Console.Write("- вкусняшка: сьев ее игроку прибавляется три очка");
            Console.Write("\n 2. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("о ");
            Console.ResetColor();
            Console.Write("- яд: сьев ее у игрока отнимается два очка");
            Console.WriteLine("\n 3. яд появляется через каждые две вкусняшки");
            Console.WriteLine(" 4. каждые сто шагов скорость передвижения змейки увеличивается");
            Console.WriteLine(" 5. при столкновении головы змейки с рамкой или с хвостом игра прекращается");
            Console.ResetColor(); // сбрасываем в стандартный

        }
    }
}
