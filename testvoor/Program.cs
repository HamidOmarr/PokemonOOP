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

