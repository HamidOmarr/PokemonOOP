using System;
using System.Xml.Linq;

namespace PokemonSimulator
{
    class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, "fire", "water") { }

        public override void BattleCry()
        {
            Console.WriteLine($"Charmander, {Name}!");
        }
    }
}

