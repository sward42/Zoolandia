using System;

namespace Zoolandia.Animals
{
    public class Otariidae : Animal
    {
        public string commonName = "Sea Lion";

        public int maxWeightKg = 1000;
        public string habitat = "coastal waters and rocky shorelines";
        public override void Type()
        {
            base.Type();
            Console.WriteLine ("This animal is a sea dwelling mammal.");
        }
        public Otariidae()
        {
            this.name = "Penelope";
        }
        public Otariidae(string name)
        {
            this.name = name;
        }
        public Otariidae(int weightKg)
        {
            this.weightKg = weightKg;
        }
        public Otariidae(int weightKg, string name)
        {
            this.weightKg = weightKg;
            this.name = name;
        }
    }
}