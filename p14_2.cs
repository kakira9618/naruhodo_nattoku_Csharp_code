﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<IVirtualPet>();
            var pet1 = new FoodiePet("エイミー");
            var pet2 = new CheerfulPet("クー");
            var pet3 = new SleepyPet("ライアン");
            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);

            foreach (var pet in pets)
            {
                pet.Eat();
                pet.Play();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }
        }
    }

    interface IVirtualPet
    {
        string Name { get; }
        int Mood { get; set; }
        int Energy { get; set; }

        void Eat();
        void Play();
        void Sleep();
    }

    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public FoodiePet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }
        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()
        {
            Mood += 0;
            Energy += 3;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood += 3;
            Energy -= 3;
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood -= 1;
            Energy += 3;
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }
    }

    class SleepyPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }
        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()
        {
            Mood -= 1;
            Energy += 1;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public void Play()
        {
            Mood -= 1;
            Energy -= 1;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public void Sleep()
        {
            Mood += 2;
            Energy += 1;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
    }
}
