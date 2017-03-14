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
        string ans;

        public int Choice
        {
            get { return choice; }
        }

        public void Start()
        {
            Console.Clear();
            Messages.Welcome();
            Console.WriteLine("\t =======================================");
            Console.WriteLine("\t       1. START GAME");
            Console.WriteLine("\t       2. HIGH SCORES");
            Console.WriteLine("\t       3. EXIT GAME");
            Console.WriteLine("\t =======================================");

            Console.Write("\n> Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }

        public void Finish()
        {
            Messages.Goodbye();
        }

        public bool Continue()
        {
            Console.Write("\n> Continue (y/n)? - ");
            ans = Console.ReadLine();
            return (ans == "y");
        }
    }
}
