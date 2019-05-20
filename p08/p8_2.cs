using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmi = BmiCalculator.GetBmi(158, 45);
            var type = BmiCalculator.GetBodyType(bmi);
            Console.WriteLine($"あなたは「{type}」です。");
        }

        static class BmiCalculator
        {
            public static double GetBmi(double height, double weight)
            {
                var metersTall = height / 100.0;
                var bmi = weight / (metersTall * metersTall);
                return bmi;
            }

            public static string GetBodyType(double bmi)
            {
                if (bmi < 18.5)
                {
                    return "痩せ型";
                } else if (bmi < 25)
                {
                    return "普通体重";
                } else if (bmi < 30)
                {
                    return "肥満(1度)";
                } else if (bmi < 35)
                {
                    return "肥満(2度)";
                } else if (bmi < 40)
                {
                    return "肥満(3度)";
                } else
                {
                    return "肥満(4度)";
                }
            }
        }
    }
}
