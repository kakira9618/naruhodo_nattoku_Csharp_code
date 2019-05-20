using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointRate = 0.01;
            var price = int.Parse(Console.ReadLine());
            var basePoint = (int)(price * pointRate);
            var point = basePoint * 5;

            Console.WriteLine($"ポイント5倍の日は、{price}円の商品が{point}ポイントになります。");
        }
    }
}
