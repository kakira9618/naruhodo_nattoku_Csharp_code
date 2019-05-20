using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            object book = new Book("test book", "kakira", 123, 5);
            Console.WriteLine(book);
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Book(string title, string author, int pages, int rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"[{Title}]({Author})";
        }
    }
}
