using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class ToxicCreator
    {
        int mapWidth;
        int mapHeight;
        char symb;

        Random random = new Random(DateTime.Now.Millisecond);

        public ToxicCreator(int mapWidth, int mapHeight, char symb)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }

        public Point CreateToxic()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
