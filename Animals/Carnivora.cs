using System;

namespace Zoolandia.Animals
{
    public class Carnivora : Mammalia
    {
        public virtual void Meat()
        {
            Console.WriteLine("This type of animal is a carnivore.");
        }
    }
}