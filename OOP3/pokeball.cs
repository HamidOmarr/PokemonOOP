using PokemonSimulator;

namespace PokemonSimulator
{
    internal class pokeball
    {
        public Charmander charmander; 

        public pokeball(Charmander charmander)
        {
            this.charmander = charmander;
        }

        public void Open()
        {
            Console.WriteLine("de Pokeball is Open.");
        }
        public void Close()
        {
            Console.WriteLine("de Pokeball is Dicht.");
        }
    }
}
