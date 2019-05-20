using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[20];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 100;
            }

            foreach(var num in nums)
            {
                Console.WriteLine($"{num}");
            }
        }
    }
}
