using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Messages.Welcome();
            Thread.Sleep(1000);
            Console.Clear();
            int width = 0;
            int height = 0;
            GameProcess gameProcess = new GameProcess();

            do
            {
                m.Start();
                switch (m.Choice)
                {
                    case 1:
                        m.Start1();

                        switch (m.Choice1)
                        {

                            case 1:

                                do
                                {
                                    Console.Write("\n Введите ширину(не менее 10 и не более 160) : ");
                                    width = int.Parse(Console.ReadLine());
                                } while ((width < 10) || (width > 160));

                                do
                                {
                                    Console.Write("\n Введите высоту(не менее 10 и не более  50) : ");
                                    height = int.Parse(Console.ReadLine());
                                } while ((height < 10) || (height > 50));

                                Console.Clear();
                                gameProcess.StartGame((width+2), (height+2));

                                break;

                            case 2:
                                Console.Write("\n стандартные параметры : ");
                                Console.Clear();
                                width = 80;
                                height = 25;
                                gameProcess.StartGame(width, height);

                                break;
                        }
                       break;
                    case 2:
                        Messages.Rules();
                        break;
                    case 3:
                        ScoreList.Display();
                        break;
                    case 4:
                        m.Finish();
                        break;
                }
            }
            while (m.Continue());

            m.Finish();
        }
    }
}
