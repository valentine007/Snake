using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Snake
{
    class AddScore
    {
        int score;

        public AddScore(int score)
        {
            this.score = score;
        }

        public void AddUser()
        {
            XDocument doc = new XDocument();
            doc = XDocument.Load(@"..\..\data.xml");

            var orderedtabs = doc.Element("results");
            string datNow = DateTime.Now.ToString("dd.MM.yy");   //текущая дата

            XElement gamer_ = new XElement("gamer");            // создаем элемент

            Console.Write("\n Введите имя : ");
            string nam = Console.ReadLine();


            XAttribute g_name = new XAttribute("name", nam);            // создаем атрибут
            XElement rat = new XElement("rate", score);              //создаем элемент 
            XElement date = new XElement("date", datNow);               //создаем эелемент дата
            // добавляем атрибут и элементы в созданный корневой элемент
            gamer_.Add(g_name);
            gamer_.Add(rat);
            gamer_.Add(date);

            orderedtabs.Add(gamer_);            //добавляем созданный корневой элемент в наш документ
            doc.Save(@"..\..\data.xml");
            Console.WriteLine("\n\t\t\tзапись файла ");

            ScoreList ScoreList = new ScoreList();        //добавляем статистику по игроку
            ScoreList.Display();

            Console.WriteLine("\n\t\t\tВаш результат: \n\t\t\t{0} - {1} - {2}", nam, score, datNow);            
        }
    }
}
