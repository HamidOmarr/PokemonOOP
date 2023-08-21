using PokemonSimulator;

namespace PokemonSimulator
{
    abstract class Pokemon
    {
        public string Name { get; protected set; }
        public string Strength { get; protected set; }
        public string Weakness { get; protected set; }

        public Pokemon(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public abstract void BattleCry();
    }
}
