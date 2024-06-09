using PrototypePattern_GameCharacter.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_GameCharacter.Models
{
    public class Mage : GameCharacter
    {
        public string Spell { get; set; }

        public Mage(string name, int health, int attack, string spell, List<string> skills)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Spell = spell;
            Skills = new List<string>(skills);
        }

        public override object Clone()
        {
            // Derin kopyalama (deep copy)
            Mage clone = (Mage)this.MemberwiseClone();
            clone.Skills = new List<string>(this.Skills);
            return clone;
        }

        public override string ToString()
        {
            return base.ToString() + $", Spell: {Spell}";
        }
    }
}
