using PokemonSimulator;

namespace PokemonSimulator
{
    internal class trainer
    {
        string name;
        List<pokeball> belt;

        public trainer(string name, List<pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }

        public void throwPokeball(int number)
        {
            Console.WriteLine(name + " gooit pokeball");

            belt[number].Open();
            belt[number].charmander.BattleCry(); 
        }


        public void returnPokeball(int number)
        {
            Console.WriteLine(name + " terug-gebracht pokemon");

            belt[number].Close();
        }
    }
}
