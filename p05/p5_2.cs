using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var longest = "";
            for(int i = 0; i < 10; i++)
            {
                var str = Console.ReadLine();
                if (str.Length > longest.Length)
                {
                    longest = str;
                }
            }
            Console.WriteLine($"最も長いのは{longest}でした。");
        }
    }
}
