using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human troy = new Human("Troy");
            Console.WriteLine(troy.name);
            Human sam = new Human("Sam", 5, 7, 5, 120);
            Console.WriteLine("Character Name: " + troy.name + " Health: " + troy.health + " Intelligence: " + troy.intelligece + " Dexterity: " + troy.dexterity + " Strength: " + troy.strength);
            Console.WriteLine("Character Name: " + sam.name + " Health: " + sam.health + " Intelligence: " + sam.intelligece + " Dexterity: " + sam.dexterity + " Strength: " + sam.strength);
            Console.WriteLine(troy.name + " is attacking " + sam.name);
            troy.Attack(sam);
            Console.WriteLine("Character Name: " + troy.name + " Health: " + troy.health + " Intelligence: " + troy.intelligece + " Dexterity: " + troy.dexterity + " Strength: " + troy.strength);
            Console.WriteLine("Character Name: " + sam.name + " Health: " + sam.health + " Intelligence: " + sam.intelligece + " Dexterity: " + sam.dexterity + " Strength: " + sam.strength);
        }
    }
}
