using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for(int i = 1; i <= 500; i++)
            {
                if (i % 3 != 0 && i % 7 != 0) continue;
                if (i % 2 == 0) continue;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
