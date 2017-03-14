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
            //Console.Clear();
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t╔═══╦══╦╗──╔╦═══╗");
            Console.WriteLine("\t\t\t║╔══╣╔╗║║──║║╔══╝");
            Console.WriteLine("\t\t\t║║╔═╣╚╝║╚╗╔╝║╚══╗");
            Console.WriteLine("\t\t\t║║╚╗║╔╗║╔╗╔╗║╔══╝");
            Console.WriteLine("\t\t\t║╚═╝║║║║║╚╝║║╚══╗");
            Console.WriteLine("\t\t\t╚═══╩╝╚╩╝──╚╩═══╝");
            Console.WriteLine();
            Console.WriteLine("\t\t\t╔══╦╗╔╦═══╦═══╦╗");
            Console.WriteLine("\t\t\t║╔╗║║║║╔══╣╔═╗║║");
            Console.WriteLine("\t\t\t║║║║║║║╚══╣╚═╝║║");
            Console.WriteLine("\t\t\t║║║║╚╝║╔══╣╔╗╔╩╝");
            Console.WriteLine("\t\t\t║╚╝╠╗╔╣╚══╣║║║╔╗");
            Console.WriteLine("\t\t\t╚══╝╚╝╚═══╩╝╚╝╚╝");
        }

        public static void GameStart()
        {
            //Console.Clear();
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t╔═══╦══╦╗──╔╦═══╗");
            Console.WriteLine("\t\t\t║╔══╣╔╗║║──║║╔══╝");
            Console.WriteLine("\t\t\t║║╔═╣╚╝║╚╗╔╝║╚══╗");
            Console.WriteLine("\t\t\t║║╚╗║╔╗║╔╗╔╗║╔══╝");
            Console.WriteLine("\t\t\t║╚═╝║║║║║╚╝║║╚══╗");
            Console.WriteLine("\t\t\t╚═══╩╝╚╩╝──╚╩═══╝");
            Console.WriteLine();
            Console.WriteLine("\t\t\t╔══╦════╦══╦═══╦════╦╗");
            Console.WriteLine("\t\t\t║╔═╩═╗╔═╣╔╗║╔═╗╠═╗╔═╣║");
            Console.WriteLine("\t\t\t║╚═╗─║║─║╚╝║╚═╝║─║║─║║");
            Console.WriteLine("\t\t\t╚═╗║─║║─║╔╗║╔╗╔╝─║║─╚╝");
            Console.WriteLine("\t\t\t╔═╝║─║║─║║║║║║║──║║─╔╗");
            Console.WriteLine("\t\t\t╚══╝─╚╝─╚╝╚╩╝╚╝──╚╝─╚╝");
        }

        public static void Welcome()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t████████████████████████████████████████████");
            Console.WriteLine("\t\t█─███─█───█─███────█────█─███─█───█───█────█");
            Console.WriteLine("\t\t█─███─█─███─███─██─█─██─█──█──█─████─██─██─█");
            Console.WriteLine("\t\t█─█─█─█───█─███─████─██─█─█─█─█───██─██─██─█");
            Console.WriteLine("\t\t█─────█─███─███─██─█─██─█─███─█─████─██─██─█");
            Console.WriteLine("\t\t██─█─██───█───█────█────█─███─█───██─██────█");
            Console.WriteLine("\t\t████████████████████████████████████████████");
            Console.WriteLine("\t\t\t█────█────█─███─█───█─█");
            Console.WriteLine("\t\t\t█─████─██─█──█──█─███─█");
            Console.WriteLine("\t\t\t█─█──█────█─█─█─█───█─█");
            Console.WriteLine("\t\t\t█─██─█─██─█─███─█─█████");
            Console.WriteLine("\t\t\t█────█─██─█─███─█───█─█");
            Console.WriteLine("\t\t\t███████████████████████");
        }

        public static void Goodbye()
        {
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
        }
    }
}
