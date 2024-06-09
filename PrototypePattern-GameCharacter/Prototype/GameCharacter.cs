using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_GameCharacter.Prototype
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public List<string> Skills { get; set; }

        public abstract object Clone();
        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Attack: {Attack}, Skills: {string.Join(", ", Skills)}";
        }

    }
}
