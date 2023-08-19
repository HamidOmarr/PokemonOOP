using System;

class Pokeball
{
    private bool isOpen;
    private Charmander charmander;

    public Pokeball()
    {
        isOpen = false;
        charmander = null;
    }

    public void Open()
    {
        isOpen = true;
    }

    public void Close()
    {
        isOpen = false;
    }

    public bool IsOpen()
    {
        return isOpen;
    }

    public void ReleaseCharmander()
    {
        if (charmander != null)
        {
            charmander.BattleCry();
        }
    }

    public void SetCharmander(Charmander charmander)
    {
        this.charmander = charmander;
    }

    public Charmander GetCharmander()
    {
        return charmander;
    }
}

class Charmander
{
    public string name;
    public string strength;
    public string weakness;

    public Charmander(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public void BattleCry()
    {
        Console.WriteLine(name + "!");
    }
}

class Trainer
{
    public string name;
    public List<Pokeball> belt;

    public Trainer(string name)
    {
        this.name = name;
        belt = new List<Pokeball>();
        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball());
        }
    }

    public void ThrowPokeball(int index)
    {
        if (index >= 0 && index < belt.Count)
        {
            Pokeball pokeball = belt[index];
            if (!pokeball.IsOpen())
            {
                pokeball.Open();
                Charmander charmander = pokeball.GetCharmander();
                if (charmander != null)
                {
                    charmander.BattleCry();
                }
            }
        }
    }

    public void ReturnPokemon(int index)
    {
        if (index >= 0 && index < belt.Count)
        {
            Pokeball pokeball = belt[index];
            if (pokeball.IsOpen())
            {
                pokeball.Close();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom! Dit is Pokemon Battle Simulator!");

        Console.Write("Naam van de 1ste trainer: ");
        string trainer1Name = Console.ReadLine();
        Trainer trainer1 = new Trainer(trainer1Name);

        Console.Write("Naam van de 2de trainer: ");
        string trainer2Name = Console.ReadLine();
        Trainer trainer2 = new Trainer(trainer2Name);

        for (int i = 0; i < 6; i++)
        {
            trainer1.belt[i].SetCharmander(new Charmander("Charmander", "Vuur", "Water"));
            trainer2.belt[i].SetCharmander(new Charmander("Charmander", "Vuur", "Water"));
        }

        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Ronde " + (i + 1));

            Console.WriteLine(trainer1.name + " gooit Pokeball " + (i + 1));
            trainer1.ThrowPokeball(i);

            Console.WriteLine(trainer2.name + " gooit Pokeball " + (i + 1));
            trainer2.ThrowPokeball(i);

            Console.WriteLine();

            Console.ReadLine();
        }

        Console.WriteLine("Bye");
        Console.ReadLine();
    }
}













/*// using System;
using System.Collections.Generic;

abstract class Pokemon
{
    public string Name { get; protected set; }
    public string Strength { get; protected set; }
    public string Weakness { get; protected set; }

    protected Pokemon(string name, string strength, string weakness)
    {
        Name = name;
        Strength = strength;
        Weakness = weakness;
    }

    public abstract void BattleCry();
}

class Squirtle : Pokemon
{
    public Squirtle(string name) : base(name, "Water", "Leaf") { }

    public override void BattleCry()
    {
        Console.WriteLine(Name + "!");
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string name) : base(name, "Grass", "Fire") { }

    public override void BattleCry()
    {
        Console.WriteLine(Name + "!");
    }
}

class Charmander : Pokemon
{
    public Charmander(string name) : base(name, "Fire", "Water") { }

    public override void BattleCry()
    {
        Console.WriteLine(Name + "!");
    }
}

class Trainer
{
    public string Name { get; }
    public List<Pokemon> Belt { get; }

    private int squirtleIndex;
    private int bulbasaurIndex;
    private int charmanderIndex;

    public Trainer(string name)
    {
        Name = name;
        Belt = new List<Pokemon>();
        squirtleIndex = 0;
        bulbasaurIndex = 2;
        charmanderIndex = 4;

        // Add two instances of each Pokemon to the trainer's belt
        Belt.Add(new Squirtle("Squirtle"));
        Belt.Add(new Squirtle("Squirtle"));
        Belt.Add(new Bulbasaur("Bulbasaur"));
        Belt.Add(new Bulbasaur("Bulbasaur"));
        Belt.Add(new Charmander("Charmander"));
        Belt.Add(new Charmander("Charmander"));
    }

    public void ThrowPokeball()
    {
        if (squirtleIndex < Belt.Count && bulbasaurIndex < Belt.Count && charmanderIndex < Belt.Count)
        {
            Pokemon pokemon;
            if (squirtleIndex < Belt.Count)
            {
                pokemon = Belt[squirtleIndex];
                Console.WriteLine(Name + " throws a pokeball!");
                pokemon.BattleCry();
                squirtleIndex++;
            }

            if (bulbasaurIndex < Belt.Count)
            {
                pokemon = Belt[bulbasaurIndex];
                Console.WriteLine(Name + " throws a pokeball!");
                pokemon.BattleCry();
                bulbasaurIndex++;
            }

            if (charmanderIndex < Belt.Count)
            {
                pokemon = Belt[charmanderIndex];
                Console.WriteLine(Name + " throws a pokeball!");
                pokemon.BattleCry();
                charmanderIndex++;
            }
        }
    }

    public void ReturnPokemon()
    {
        squirtleIndex--;
        bulbasaurIndex--;
        charmanderIndex--;

        Console.WriteLine(Name + " returns the pokemon to its pokeball.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
            Console.Write("Enter the name of the first trainer: ");
            string trainer1Name = Console.ReadLine();
            Trainer trainer1 = new Trainer(trainer1Name);

            Console.Write("Enter the name of the second trainer: ");
            string trainer2Name = Console.ReadLine();
            Trainer trainer2 = new Trainer(trainer2Name);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\nRound " + (i + 1));

                trainer1.ThrowPokeball();
                trainer2.ThrowPokeball();

                trainer1.ReturnPokemon();
                trainer2.ReturnPokemon();
            }

            Console.Write("\nDo you want to play again? (Y/N): ");
            string playAgain = Console.ReadLine();

            quit = !(playAgain.ToLower() == "y" || playAgain.ToLower() == "yes");

            Console.Clear();
        }

        Console.WriteLine("Thank you for playing the Pokemon Battle Simulator!");
    }
}

*/
