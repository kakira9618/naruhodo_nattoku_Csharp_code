using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtask1();
            subtask2();
        }

        static void subtask1()
        {
            bool continueFlag;
            int ans = 0;
            do
            {
                continueFlag = false;
                try
                {
                    var total = 1000;
                    var line = Console.ReadLine();
                    var count = int.Parse(line);
                    ans = total / count;
                }
                catch
                {
                    continueFlag = true;
                }
            } while (continueFlag);

            Console.WriteLine(ans);
            Console.WriteLine("正常終了");
        }
        static void subtask2()
        {
            string line;
            int count;
            do
            {
                line = Console.ReadLine();
            } while (!int.TryParse(line, out count) || count == 0);

            var total = 1000;
            var ans = total / count;
            Console.WriteLine(ans);
            Console.WriteLine("正常終了");
        }
    }
}
