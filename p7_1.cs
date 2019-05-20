using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Title = "test book",
                Author = "kakira",
                Pages = 123,
                Rating = 5,
                Memo = ""
            };
            book.Print();
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public int Rating { get; set; }
            public string Memo { get; set; }

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
}
