using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, a = 20, b = 30, n = 40, k = 50;
            x /= 2;
            a += b * 2;
            n *= k + 4;

            Console.WriteLine($"x: {x}, a: {a}, n: {n} です");
        }
    }
}
