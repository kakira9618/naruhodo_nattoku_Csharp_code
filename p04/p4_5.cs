using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = int.Parse(Console.ReadLine());
            if (point < 0 || point > 100)
            {
                Console.WriteLine("入力した数値に誤りがあります");
            } else if (point <= 30)
            {
                Console.WriteLine("不可");
            } else if (point <= 60)
            {
                Console.WriteLine("可");
            } else if (point <= 80)
            {
                Console.WriteLine("良");
            } else if (point <= 100)
            {
                Console.WriteLine("優");
            } else
            {
            }
        }
    }
}
