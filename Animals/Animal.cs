using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public string color { get; set; }
        public string Sleep()
        {
            return "Animal is sleeping";
        }
    }
}