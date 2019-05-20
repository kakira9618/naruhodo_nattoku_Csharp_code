using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\temp\祇園精舎.txt";
            /*
            var lines = new string[]
            {
                "祇園精舎の鐘の声、諸行無常の響きあり。",
                "沙羅双樹の花の色、盛者必衰の理をあらはす。",
                "驕れる人も久しからず、ただ春の世の夢のごとし。",
                "猛き者もつひにはほろびぬ、ひとえに風の前の塵に同じ。"
            };
            File.WriteAllLines(filename, lines);
            */

            var lines = File.ReadAllLines(filename);
            var sum = 0;
            foreach(var line in lines)
            {
                sum += line.Length;
            }
            Console.WriteLine($"合計: {sum}文字");

            foreach (var line in lines)
            {
                var splitedText = line.Split('、');
                foreach (var text in splitedText)
                {
                    Console.WriteLine(text);
                }
            }
            
        }
    }
}
