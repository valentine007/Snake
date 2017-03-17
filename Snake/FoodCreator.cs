using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char symb;

        public static int counter = 0; // счетчик созданных экземпляров еды

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symb)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            counter++;  // увеличиваем счетчик каждый раз когда создается еда
            return new Point(x, y, symb);
        }
    }
}
