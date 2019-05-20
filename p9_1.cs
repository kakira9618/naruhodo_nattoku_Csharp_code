using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double min = Math.Min(a, b);

            Console.WriteLine($"{a}と{b}のうち小さい方は{min}");

            while(true)
            {
                string numStr = Console.ReadLine();
                if (numStr == "")
                {
                    break;
                }
                double num = double.Parse(numStr);

                Console.WriteLine($"切り捨て:{Math.Floor(num)} 切り上げ:{Math.Ceiling(num)}");
            }
        }
    }
}
