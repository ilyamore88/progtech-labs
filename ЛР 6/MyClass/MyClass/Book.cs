using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public static double Price { get; set; }
        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price)
        {
            Book.Price = price;
        }
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}", Author, Title, Year, Pages, Price);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public double PriceBook(int s)
        {
            double cust = s * Price;
            return cust;
        }

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public Book() { }
        static Book()
        {
            Price = 9;
        }
        public Book (string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
    }
}
