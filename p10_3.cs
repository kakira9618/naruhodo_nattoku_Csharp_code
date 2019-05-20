using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("名前を入力してください⇒");
            var name = Console.ReadLine();
            var mypet = new VirtualPet(name);

            mypet.MoodDown();
            // mypet.Mood = 100;

            Console.WriteLine($"Name: {mypet.Name}");
            Console.WriteLine($"Mood: {mypet.Mood}");
            Console.WriteLine($"Energy: {mypet.Energy}");


        }
    }

    class VirtualPet
    {
        public string Name { get; set; }
        public int Mood { get; private set; }
        public int Energy { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public void MoodUp()
        {
            Mood++;
            if (Mood >= 10)
            {
                Mood = 10;
            }
        }

        public void MoodDown()
        {
            Mood--;
            if (Mood <= 1)
            {
                Mood = 1;
            }
        }
    }
}
