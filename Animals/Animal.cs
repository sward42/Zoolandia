using System;

namespace Zoolandia.Animals
{
    public class Animal: IReptile
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

        bool IReptile.hasScales()
        {
            return true;
        }

        void IReptile.noFlight()
        {
            Console.WriteLine("Reptiles do not fly, only glide.");
        }

        void IReptile.iceCold()
        {
            Console.WriteLine("Reptiles can not regulate their own body temperature internally.");
        }
    }
}