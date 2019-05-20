using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "aa", "aaaaaa", "b", "kakira" };

            var longest = "";
            foreach(var str in strs)
            {
                if (str.Length >= longest.Length)
                {
                    longest = str;
                }
            }

            Console.WriteLine($"最も長いのは{longest}でした。");
        }
    }
}
