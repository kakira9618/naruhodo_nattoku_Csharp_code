using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[8];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach(var num in nums)
            {
                sum += num;
            }

            double avg = (double)sum / nums.Length;

            Console.WriteLine($"合計: {sum}");
            Console.WriteLine($"平均: {avg}");

        }
    }
}
