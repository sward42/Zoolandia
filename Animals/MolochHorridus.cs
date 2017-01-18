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
        public MolochHorridus(string name)
        {
            this.name = name;
        }
        public MolochHorridus(int weightKg)
        {
            this.weightKg = weightKg;
        }
        public MolochHorridus(int weightKg, string name)
        {
            this.name = name;
            this.weightKg = weightKg;
        }
    }
}