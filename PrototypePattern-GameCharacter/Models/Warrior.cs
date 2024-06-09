using PrototypePattern_GameCharacter.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_GameCharacter.Models
{
    public class Warrior : GameCharacter
    {
        public string Weapon { get; set; }

        public Warrior(string name, int health, int attack, string weapon, List<string> skills)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Weapon = weapon;
            Skills = new List<string>(skills);
        }

        public override object Clone()
        {
            // Derin kopyalama (deep copy)
            Warrior clone = (Warrior)this.MemberwiseClone();
            clone.Skills = new List<string>(this.Skills);
            return clone;
        }

        public override string ToString()
        {
            return base.ToString() + $", Weapon: {Weapon}";
        }

    }
}
    