using System;
using System.Collections.Generic;

namespace PokemonSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom! Dit is de Pokemon battle simulator!");

            List<Pokemon> belt = new List<Pokemon>
            {
                new Squirtle("Squirtle"),
                new Squirtle("Squirtle2"),
                new Bulbasaur("Bulbasaur"),
                new Bulbasaur("Bulbasaur2"),
                new Charmander("Charmander"),
                new Charmander("Charmander2")
            };

            Console.Write("Geef een naam aan de 1ste trainer: ");
            string trainer1Name = Console.ReadLine();

            Console.Write("Geef een naam aan de 2nde trainer: ");
            string trainer2Name = Console.ReadLine();

            int currentPokemonIndex = 0;

            bool SpeelOpnieuw = true;
            while (SpeelOpnieuw)
            {
                Console.WriteLine($"{trainer1Name} gooit de pokeball!");
                belt[currentPokemonIndex].BattleCry();

                Console.WriteLine($"{trainer2Name} gooit de pokeball!");
                currentPokemonIndex++;
                belt[currentPokemonIndex].BattleCry();

                Console.WriteLine($"{trainer1Name} haalt zijn pokemon terug.");
                Console.WriteLine($"{trainer2Name} haalt zijn pokemon terug.");

                currentPokemonIndex++;

                if (currentPokemonIndex >= belt.Count)
                {
                    Console.WriteLine("Alle pokeballs zijn gebruikt.");
                    Console.Write("Wil je doorgaan? (ja/nee): ");
                    string response = Console.ReadLine();
                    if (response.ToLower() == "nee")
                    {
                        SpeelOpnieuw = false;
                    }
                    currentPokemonIndex = 0;
                }
            }

            Console.WriteLine("byebye");
        }
    }
}

