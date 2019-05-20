using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("test book", "kakira");
            book.Print();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public string Memo { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Print()
        {
            Console.WriteLine($"タイトル: {Title}");
            Console.WriteLine($"著者: {Author}");
            Console.WriteLine($"ページ数: {Pages}");
            Console.WriteLine($"レーティング: {Rating}");
            Console.WriteLine($"メモ: {Memo}");
        }
    }
}
