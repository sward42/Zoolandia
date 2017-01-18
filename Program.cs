using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Meet my animal friends!");

            var ThornyDevil = new MolochHorridus();
            ThornyDevil.color = "Green & Gray";
            
            Console.WriteLine($"My pet {ThornyDevil.name} is a {ThornyDevil.commonName} and has {ThornyDevil.color} {ThornyDevil.skinType}.  He is pretty fast and can run {ThornyDevil.speedKph} Kph.");
            ThornyDevil.Type();

            var Baboon = new Papio();
            Baboon.name = "Bernard";

            Console.WriteLine($"My {Baboon.commonName}, {Baboon.name}, eats everything in sight since he is an {Baboon.diet}.  Some people think baboons are endangered but that is {Baboon.endangered}.");
            Baboon.Type();

            var SeaLion = new Otariidae();
            SeaLion.name = "Penelope";

            Console.WriteLine($"{SeaLion.name} is my friendly {SeaLion.commonName} who enjoys spending her time in {SeaLion.habitat}.  She prefers the water because it is easier to move about since she weighs nearly {SeaLion.maxWeightKg} kg!");
            SeaLion.Type();
        }
    }
}
