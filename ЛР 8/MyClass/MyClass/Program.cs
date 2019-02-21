using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.SetPrice(12);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            List<Item> itList = new List<Item>();
            itList.AddRange(new Item[] { b2, mag1 });
            itList.Sort();
            Console.WriteLine("Сортировка по инвентарному номеру: ");
            foreach (Item item in itList)
            {
                item.Print();
            }
            Audit.RunAudit();
            mag1.Subs();
        }
    }
}
