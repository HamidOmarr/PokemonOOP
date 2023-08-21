using System;
using System.Collections.Generic;
using PokemonSimulator;

namespace PokemonSimulator
{
    class Arena
    {
        private static int battles = 0;

        public static void FightArena(trainer trainer1, trainer trainer2)
        {
            Console.WriteLine("Arenagevecht begint!");

            for (int pokeballNumber = 0; pokeballNumber < 3; pokeballNumber++)
            {
                Console.WriteLine($"Ronde {pokeballNumber + 1}:");
                Battle.FightRound(trainer1, trainer2, pokeballNumber);

                if (trainer1.PokeballsEmpty() && trainer2.PokeballsEmpty())
                    break;
            }

            ArenaWinnaar(trainer1, trainer2);
            battles++;
        }

        private static void ArenaWinnaar(trainer trainer1, trainer trainer2)
        {
            int score1 = trainer1.Score;
            int score2 = trainer2.Score;

            Console.WriteLine($"Score {trainer1.GetName()}: {score1}");
            Console.WriteLine($"Score {trainer2.GetName()}: {score2}");

            if (score1 > score2)
            {
                Console.WriteLine($"{trainer1.GetName()} wint het gevecht!");
            }
            else if (score2 > score1)
            {
                Console.WriteLine($"{trainer2.GetName()} wint het gevecht!");
            }
            else
            {
                Console.WriteLine("Het gevecht eindigt in een gelijkspel!");
            }
        }
    }
}
