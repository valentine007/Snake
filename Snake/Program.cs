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
            do
            {
                m.Start();
                switch (m.Choice)
                {
                    case 1:
                        Console.Clear();
                        GameProcess.StartGame();
                        break;
                    case 2:
                        break;
                    case 3:
                        m.Finish();
                        break;
                }
            }
            while (m.Continue());

            m.Finish();
        }








    }
    }

