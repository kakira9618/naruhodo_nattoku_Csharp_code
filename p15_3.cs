using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            subtask2();
        }

        static void subtask1()
        {
            var sw = new StreamWriter("sample.txt");
            try
            {
                sw.WriteLine("吾輩は猫である。");
                sw.WriteLine("名前はまだ無い。");
                sw.WriteLine("どこで生れたかとんと見当がつかぬ。");
            }
            finally
            {
                sw.Dispose();
            }
        }

        static void subtask2()
        {
            using (var sw = new StreamWriter("sample.txt"))
            {
                sw.WriteLine("吾輩は猫である。");
                sw.WriteLine("名前はまだ無い。");
                sw.WriteLine("どこで生れたかとんと見当がつかぬ。");
            }
        }
    }
}
