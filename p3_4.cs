using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            Console.WriteLine($"交換前は a: {a}, b: {b}");

            // 交換(swap)処理
            var c = a;
            a = b;
            b = c;

            Console.WriteLine($"交換後は a: {a}, b: {b}");
        }
    }
}
