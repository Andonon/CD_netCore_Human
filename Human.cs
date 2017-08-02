using System;

namespace human {

    public class Human
    {
        public string name;
        public int strength = 3;
        public int intelligece = 3;
        public int dexterity = 3;
        public int health = 100;
    
    
        public Human(string givenname) 
        {
            name = givenname;
        }
    
        public Human(string givenname, int givenstrength, int givenintelligence, int givendexterity, int givenhealth) 
        {
            name = givenname;
            strength = givenstrength;
            intelligece = givenintelligence;
            dexterity = givendexterity;
            health = givenhealth;
        }
    
        public void Attack(Object targetname) 
        {
            if (targetname is Human)
          {
            Human victim = targetname as Human;
            victim.health -= strength * 5;
            Console.WriteLine(victim + "was injured in attack, lost " + strength * 5 + " points damage.");
          }
        }
    
    
    }
}