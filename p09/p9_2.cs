using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = 2020;
            var month = 2;
            var day = 10;

            var days = DateTime.DaysInMonth(year, month);

            Console.WriteLine($"{year}年{month}月は{days}日あります。");

            var date = DateTime.Parse($"{year}/{month}/{day}");

            Console.WriteLine($"{year}年{month}月{day}日は{date.ToString("ddd")}曜日です");
        }
    }
}
