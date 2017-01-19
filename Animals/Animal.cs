using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public string color { get; set; }
        public int weightKg { get; set; }
        public string Sleep()
        {
            return "Animal is sleeping";
        }
        public virtual void Type()
        {
            Console.Write( "This animal is...");
        }
    }
}