using System;
using System.Collections.Generic;
using PokemonSimulator;

namespace PokemonSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom! Dit is de Pokemon battle simulator!");

            List<pokeball> belt1 = new List<pokeball>
            {
                new pokeball(new Squirtle("Squirtle")),
                new pokeball(new Bulbasaur("Bulbasaur")),
                new pokeball(new Charmander("Charmander"))
            };

            List<pokeball> belt2 = new List<pokeball>
            {
                new pokeball(new Squirtle("Squirtle")),
                new pokeball(new Bulbasaur("Bulbasaur")),
                new pokeball(new Charmander("Charmander"))
            };

            Console.Write("Geef een naam aan de 1ste trainer: ");
            string trainer1Naam = Console.ReadLine();

            Console.Write("Geef een naam aan de 2nde trainer: ");
            string trainer2Naam = Console.ReadLine();

            trainer trainer1 = new trainer(trainer1Naam, belt1);
            trainer trainer2 = new trainer(trainer2Naam, belt2);

            string OpnieuwDoen;
            do
            {
                Arena.FightArena(trainer1, trainer2);

                Console.Write("Wil je doorgaan? (ja/nee): ");
                OpnieuwDoen = Console.ReadLine();
            } while (OpnieuwDoen.ToLower() == "ja");

            Console.WriteLine("byebye");
        }
    }
}
