using PokemonSimulator;

namespace PokemonSimulator
{
    internal class pokeball
    {
        private Pokemon VastPokemon;

        public pokeball(Pokemon pokemon)
        {
            VastPokemon = pokemon;
        }

        public void Open()
        {
            
        }

        public void Close()
        {
            
        }

        public bool IsEmpty()
        {
            return VastPokemon == null;
        }

        public Pokemon GetPokemon()
        {
            return VastPokemon;
        }
    }
}
