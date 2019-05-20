using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0}は正の数です", num);
            } else if (num < 0)
            {
                Console.WriteLine("{0}は負の数です", num);
            } else
            {
                Console.WriteLine("{0}は0です", num);
            }
        }
    }
}
