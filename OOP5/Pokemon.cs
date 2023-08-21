using PokemonSimulator;

namespace PokemonSimulator
{
    enum Type
    {
        Grass,
        Fire,
        Water
    }

    abstract class Pokemon
    {
        public string Name { get; protected set; }
        public Type Strength { get; protected set; }
        public Type Weakness { get; protected set; }

        public Pokemon(string name, Type strength, Type weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public abstract void BattleCry();
    }
}
