using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dates = new List<DateTime> {
                new DateTime(2019, 4, 30),
                new DateTime(2018, 2, 28),
                new DateTime(2030, 5, 1),
            };
            Console.WriteLine($"要素数は{dates.Count}");

            foreach(var date in dates)
            {
                Console.WriteLine(date.ToString("yyyy年MM月dd日 hh:mm"));
            }
        }
    }
}
