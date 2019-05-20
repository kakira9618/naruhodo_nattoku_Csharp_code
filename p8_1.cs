using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[] { 55, 60, 45, 70, 85, 93, 68 };
            var total = ArrayUtils.Total(scores);
            var average = ArrayUtils.Average(scores);
            var max = ArrayUtils.Max(scores);
            var min = ArrayUtils.Min(scores);
            Console.WriteLine($"合計: {total}, 平均: {average}, 最大: {max}, 最小: {min}");
        }

        static class ArrayUtils
        {
            // 配列内の数値の合計を求める
            public static int Total(int[] numbers)
            {
                var total = 0;
                foreach(var n in numbers)
                {
                    total += n;
                }
                return total;
            }

            // 配列内の数値の平均を求める
            public static double Average(int[] numbers)
            {
                var total = Total(numbers);
                return (double)total / numbers.Length;
            }

            // 配列内の数値の最大を求める
            public static int Max(int[] numbers)
            {
                var maxValue = numbers[0];
                for(int i = 1; i < numbers.Length; i++)
                {
                    if (maxValue < numbers[i])
                    {
                        maxValue = numbers[i];
                    }
                }
                return maxValue;
            }

            // 配列内の数値の最小を求める
            public static int Min(int[] numbers)
            {
                var minValue = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (minValue > numbers[i])
                    {
                        minValue = numbers[i];
                    }
                }
                return minValue;
            }

        }
    }
}
