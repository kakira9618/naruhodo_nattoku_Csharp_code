using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("numは3と5で割り切れます");
            }
        }
    }
}
