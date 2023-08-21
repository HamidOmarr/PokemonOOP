using PokemonSimulator;

namespace PokemonSimulator
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, "grass", "fire") { }

        public override void BattleCry()
        {
            Console.WriteLine($"Bulbasaur, {Name}!");
        }
    }

}

