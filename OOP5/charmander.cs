using PokemonSimulator;

namespace PokemonSimulator
{
    class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, Type.Fire, Type.Water) { }

        public override void BattleCry()
        {
            Console.WriteLine($"Charmander, {Name}!");
        }
    }
}