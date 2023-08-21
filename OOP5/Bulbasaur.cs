using PokemonSimulator;

namespace PokemonSimulator
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, Type.Grass, Type.Fire) { }

        public override void BattleCry()
        {
            Console.WriteLine($"Bulbasaur, {Name}!");
        }
    }
}