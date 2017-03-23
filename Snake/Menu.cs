using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Menu
    {
        int choice;
        int choice1;
        string ans;

        public int Choice
        {
            get { return choice; }
        }
        public int Choice1
        {
            get { return choice1; }
        }

        public void Start()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Messages.Snake();
            Console.ResetColor(); // сбрасываем в стандартный
            Console.SetCursorPosition(3, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t    =======================================");
            Console.WriteLine("\t\t               1. START GAME");
            Console.WriteLine("\t\t               2. RULES");
            Console.WriteLine("\t\t               3. HIGH SCORES");
            Console.WriteLine("\t\t               4. EXIT GAME");
            Console.WriteLine("\t\t    =======================================");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Write("\n> Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }

        public void Start1()
        {
            Console.ResetColor(); // сбрасываем в стандартный
            Console.Clear();
            Messages.Snake();
            Console.ResetColor(); // сбрасываем в стандартный
            Console.SetCursorPosition(3, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t    =======================================");
            Console.WriteLine("\t\t         Хотите изменить игровое поле? ");
            Console.WriteLine("\t\t         1) Да(необходимо ввести размер)");
            Console.WriteLine("\t\t         2) Нет(размер поля по-умолчанию)");
            Console.WriteLine("\t\t    =======================================");

            Console.Write("\n> Choice: ");
            choice1 = Convert.ToInt32(Console.ReadLine());
        }

        public void Finish()
        {
            Messages.Goodbye();
        }

        public bool Continue()
        {
            Console.Write("\n\t Continue (y/n)? - ");
            ans = Console.ReadLine();
            return (ans == "y");
        }
    }
}