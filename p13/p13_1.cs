using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee {
                Number = 352,
                FirstName = "涼太",
                LastName = "田中",
                HireDate = new DateTime(2015, 10, 1),
                BirthDate = new DateTime(1994, 10, 1),
            };

            Console.WriteLine("従業員番号{0}の{1}は、{2}年に入社しました。誕生日は{3}です。", e1.Number, e1.FullName, e1.HireDate, e1.BirthDate);

            var c1 = new Custormer
            {
                Id = 352,
                FirstName = "涼太",
                LastName = "田中",
                CreditCardNumber = "0000-0000-0000-0000",
                BirthDate = new DateTime(1994, 10, 1),
            };

            Console.WriteLine("顧客番号{0}の{1}さんのクレジットカード番号は{2}です。誕生日は{3}です。", c1.Id, c1.FullName, c1.CreditCardNumber, c1.BirthDate);

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
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }

    class Employee : Person
    {
        public int Number { get; set; }
        public DateTime HireDate { get; set; }
    }

    class Custormer : Person
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
