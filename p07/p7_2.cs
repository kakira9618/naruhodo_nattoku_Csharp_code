using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee
            {
                Id = 1,
                FamilyName = "kuroiwa",
                GivenName = "akira",
                EmailAddress = "test@test.com"
            };
            var e2 = new Employee
            {
                Id = 2,
                FamilyName = "hoge",
                GivenName = "fuga",
                EmailAddress = "nya-n@test.com"
            };

            var e1Name = e1.GetFullName();
            var e2Name = e2.GetFullName();

            Console.WriteLine($"1人目の名前: {e1Name}");
            Console.WriteLine($"2人目の名前: {e2Name}");
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string EmailAddress { get; set; }

        public string GetFullName()
        {
            return $"{FamilyName} {GivenName}";
        }
    }
}
