using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
            books.Add(new Book("こころ", "夏目漱石", 378, 5));


            Console.WriteLine("[high rated]");
            var highRated = books.Where(book => book.Rating >= 4);
            foreach(var book in highRated)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("[ordered by author name]");
            var orderedByAuthorName = books.OrderBy(book => book.Author);
            foreach (var book in orderedByAuthorName)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("[books having many Pages]");
            var manyPages = books.Where(book => book.Pages >= 300).ToArray();
            foreach (var book in manyPages)
            {
                Console.WriteLine($"Title: {book.Title}, Pages: {book.Pages}");
            }

            Console.WriteLine("[the thickest book]");
            var PagesTop = books.OrderByDescending(book => book.Pages).First();
            Console.WriteLine($"Title: {PagesTop.Title}, Pages: {PagesTop.Pages}");
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
    }

}
