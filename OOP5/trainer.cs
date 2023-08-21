using System;
using System.Collections.Generic;
using PokemonSimulator;

namespace PokemonSimulator
{
    internal class trainer
    {
        private string name;
        private List<pokeball> belt;
        private int score;

        public trainer(string name, List<pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
            this.score = 0;
        }

        public Pokemon ThrowPokeball()
        {
            Console.WriteLine(name + " gooit pokeball");

            int randomPokeballIndex = new Random().Next(belt.Count); 
            pokeball chosenPokeball = belt[randomPokeballIndex];

            chosenPokeball.Open();
            return chosenPokeball.GetPokemon();
        }

        public void ReturnPokeball(int number)
        {
            Console.WriteLine(name + " terug-gebracht pokemon");

            belt[number].Close();
        }

        public bool PokeballsEmpty()
        {
            foreach (pokeball ball in belt)
            {
                if (!ball.IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        public string GetName()
        {
            return name;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}

























































