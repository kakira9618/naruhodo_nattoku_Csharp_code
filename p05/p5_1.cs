using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"入力されたのは{num}です");
            } while (num >= 0);
        }
    }
}
