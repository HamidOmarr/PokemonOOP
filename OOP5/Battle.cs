using System;
using PokemonSimulator;

namespace PokemonSimulator
{
    class Battle
    {
        public static void FightRound(trainer trainer1, trainer trainer2, int pokeballNumber)
        {
            Pokemon pokemon1 = trainer1.ThrowPokeball();
            Pokemon pokemon2 = trainer2.ThrowPokeball();

            if (pokemon1 != null && pokemon2 != null)
            {
                int result = RoundWinnaar(pokemon1, pokemon2);
                if (result == 1)
                {
                    Console.WriteLine($"{pokemon1.Name} wint van {pokemon2.Name}!");
                    trainer1.Score++; 
                    trainer2.ReturnPokeball(pokeballNumber);
                }
                else if (result == -1)
                {
                    Console.WriteLine($"{pokemon2.Name} wint van {pokemon1.Name}!");
                    trainer2.Score++; 
                    trainer1.ReturnPokeball(pokeballNumber);
                }
                else
                {
                    Console.WriteLine($"Het is een gelijkspel tussen {pokemon1.Name} en {pokemon2.Name}!");
                    trainer1.ReturnPokeball(pokeballNumber);
                    trainer2.ReturnPokeball(pokeballNumber);
                }
            }
        }


        private static int RoundWinnaar(Pokemon pokemon1, Pokemon pokemon2)
        {
            if (pokemon1.Strength == pokemon2.Weakness)
                return 1;
            else if (pokemon1.Weakness == pokemon2.Strength)
                return -1;
            else
                return 0;
        }



    }
}


