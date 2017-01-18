using System;

namespace Zoolandia.Animals
{
    public class Papio : Animal
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
    }
}