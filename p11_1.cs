using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdate = new DateTime(1994, 6, 10);
            if (birthdate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("日曜日！");
            } else
            {
                Console.WriteLine("日曜日じゃない");
            }
        }
    }
}
