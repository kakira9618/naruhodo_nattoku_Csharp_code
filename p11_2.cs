using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("akira", "kuroiwa", Gender.Male);
            if (person.Gender == Gender.Male)
            {
                Console.WriteLine("男性");
            } else
            {
                Console.WriteLine("女性");
            }
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
        public Gender Gender { get; set; }
        public Person(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }

    enum Gender
    {
        Male,
        Female
    }
}
