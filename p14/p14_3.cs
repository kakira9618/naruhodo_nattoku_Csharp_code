using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            object p = new Person
            {
                FirstName = "akira",
                LastName = "kuroiwa"
            };
            object e = new Employee
            {
                FirstName = "akira",
                LastName = "kuroiwa",
                Number = 123,
                HireDate = new DateTime(2019, 4, 1),
            };

            Console.WriteLine($"p.ToString(): {p.ToString()}");
            Console.WriteLine($"e.ToString(): {e.ToString()}");

            Console.WriteLine(p);
            Console.WriteLine(e);
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return LastName + FirstName; }
        }
    }

    class Employee : Person
    {
        public int Number { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            var s = $"{Number} {FullName} " +
                    $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
            return s;
        }
    }
}
