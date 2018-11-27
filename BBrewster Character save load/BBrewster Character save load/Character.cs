using System;
using System.Collections.Generic;
using System.Text;

namespace BBrewster_Character_save_load
{
    class Character
    {
        public string name;
        public int intelligence;
        public int strength;
        public int luck;
        public int health;
        public Character(string name,int intelligence, int strength, int luck, int health)
        {
            this.name = name;
            this.intelligence = intelligence;
            this.strength = strength;
            this.luck = luck;
            this.health = health;
        }
    }
}
