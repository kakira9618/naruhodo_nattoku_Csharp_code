using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numbers[5]);
            } catch(System.IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            
        }
    }
}
