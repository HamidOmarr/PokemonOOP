using System;


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

class Programma
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom! dit is Pokemon battle simulator!");

        Charmander charmander = new Charmander("", "Vuur", "Water");

        Console.Write("Geef Charmander een naam!: ");
        string charmanderNaam = Console.ReadLine();
        charmander = new Charmander(charmanderNaam, "Vuur", "Water");

        for (int i = 0; i < 10; i++)
        {
            charmander.BattleCry();
        }

        bool SpeelOpnieuw = true;
        while (SpeelOpnieuw)
        {
            Console.Write("Geef Charmander een naam! (of zeg 'einde' om het te beindigen.): ");
            string newName = Console.ReadLine();

            if (newName == "einde")
            {
                SpeelOpnieuw = false;
            }
            else
            {
                charmander = new Charmander(newName, "Vuur", "Water");
                for (int i = 0; i < 10; i++)
                {
                    charmander.BattleCry();
                }
            }
        }

        Console.WriteLine("bye");
    }
}
