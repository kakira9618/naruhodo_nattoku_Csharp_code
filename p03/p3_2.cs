using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = 100; // int型
            var n2 = 13; // int型
            var a1 = n1 + n2; // int型
            var a2 = -n1 / n2; // int型
            var a3 = (double)n1 / n2; // double型
            var a4 = a2 - n1; // int型
            var a5 = a3 * -2; // double型
            var a6 = a4 * 2.0M; // decimal型
        }
    }
}
