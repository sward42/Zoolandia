using System;

namespace Zoolandia.Animals
{
    public class MolochHorridus : Animal
    {
        public string commonName = "Thorny Devil";
        public int speedKph = 60;
        public string skinType = "scales";

        public override void Type()
        {
            base.Type();
            Console.WriteLine( "This animal is not a mammal, it is a reptile.");
        }

        public MolochHorridus()
        {
            this.name = "Spike";
        }
        
    }
}