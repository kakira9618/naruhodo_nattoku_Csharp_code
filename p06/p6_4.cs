using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = new string[,]
            {
                {"sun", "日曜日"},
                {"mon", "月曜日"},
                {"tue", "火曜日"},
                {"wed", "水曜日"},
                {"thu", "木曜日"},
                {"fri", "金曜日"},
                {"sat", "土曜日"},
            };

            for(int i = 0; i < days.GetLength(0); i++)
            {
                Console.WriteLine($"{days[i, 1]} ({days[i, 0]})");
            }

        }
    }
}
