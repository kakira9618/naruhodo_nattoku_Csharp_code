using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxRate = 0.08;
            var price = int.Parse(Console.ReadLine());
            var tax = (int)(price * taxRate);
            Console.WriteLine("{0}円の消費税は{1}円です。", price, tax);
        }
    }
}
