using System;

namespace Zoolandia.Animals
{
    public class Papio : Primates
    {
        public string commonName = "baboon";
        public string diet = "omnivore";
        public bool endangered = false;
        public override void Type()
        {
            base.Type();
            Console.WriteLine("This animal is a medium sized mammal.");
        }
        public Papio()
        {
            this.name = "Bernard";
        }
        public Papio(string name)
        {
            this.name = name;
        }
        public Papio(int weightKg)
        {
            this.weightKg = weightKg;
        }
        public Papio(int weightKg, string name)
        {
            this.weightKg = weightKg;
            this.name = name;
        }
    }
}