using PokemonSimulator;

namespace PokemonSimulator
{
    class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, Type.Water, Type.Grass) { }

        public override void BattleCry()
        {
            Console.WriteLine($"Squirtle, {Name}!");
        }
    }
}