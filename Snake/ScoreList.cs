using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Snake
{
    class ScoreList
    {
        public static void Display()
        {
            int _count;
            int cnt = 1;
            int n = 1;                              //переменная для счетчика итераций при выведении списка игроков.

            XDocument doc = new XDocument();

            doc = XDocument.Load(@"..\..\data.xml");

            _count = (from xe in doc.Descendants("gamer") select xe).Count();   //считаем количество игроков в списке.
            Console.WriteLine("\t----------------{0}", _count);

            var orderedtabs = doc.Element("results").Elements("gamer")
                                      .OrderByDescending(xtab => (int)xtab.Element("rate"))
                                      .ToArray();

            //var posts = doc.Descendants("gamer");       //считаем количество игроков в списке.
            //foreach (var post in posts)
            //{
            //    cnt= cnt+1;
            //}

            if (_count > 8)                          // если их больше 8 - будем обрезать выводимый список
            {
                _count = 8;

            }

            Messages.Score();
            foreach (XElement f in orderedtabs)
            {
                if (n < _count)
                {
                    Console.WriteLine("\t\t{0,3} - {1,10} - {2,7} - {3}", n, f.Attribute("name").Value, f.Element("rate").Value, f.Element("date").Value);
                    n = n + 1;
                }
            }
        }
    }
}

