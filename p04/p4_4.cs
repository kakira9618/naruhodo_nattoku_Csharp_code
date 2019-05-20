using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var term = "";

            switch (word)
            {
                case "API":
                    term = "Application Programming Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
                case "IDE":
                    term = "Integrated Development Environment";
                    break;
                case "HTML":
                    term = "HyperText Markup Language";
                    break;
            }

            if (term != "")
            {
                Console.WriteLine("{0}は{1}の略です。", word, term);
            }
        }
    }
}
