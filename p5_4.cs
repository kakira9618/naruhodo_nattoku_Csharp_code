using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while(true)
            {
                double num = double.Parse(Console.ReadLine());
                if (num <= 0) break;
                sum += num;
            }
            Console.WriteLine($"0以下の数以外の合計は{sum}でした。");
        }
    }
}
