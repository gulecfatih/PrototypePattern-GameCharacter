using PrototypePattern_GameCharacter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern_GameCharacter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prototip karakterleri oluştur
            Warrior prototypeWarrior = new Warrior("Warrior Prototype", 100, 20, "Sword", new List<string> { "Slash", "Shield Block" });
            Mage prototypeMage = new Mage("Mage Prototype", 80, 25, "Fireball", new List<string> { "Fireball", "Teleport" });

            // Prototip karakterleri klonla
            Warrior clonedWarrior1 = (Warrior)prototypeWarrior.Clone();
            Warrior clonedWarrior2 = (Warrior)prototypeWarrior.Clone();
            Mage clonedMage1 = (Mage)prototypeMage.Clone();
            Mage clonedMage2 = (Mage)prototypeMage.Clone();

            // Klonlanan karakterlerin özelliklerini yazdır
            Console.WriteLine(clonedWarrior1);
            Console.WriteLine(clonedWarrior2);
            Console.WriteLine(clonedMage1);
            Console.WriteLine(clonedMage2);

            // Klonlanan karakterlerin bazı özelliklerini değiştirelim
            clonedWarrior1.Skills.Add("Berserk");
            clonedMage1.Skills.Add("Ice Shield");

            // Değişikliklerin sadece klonlanan karakterleri etkilediğini doğrulayalım
            Console.WriteLine("\nAfter modification:");
            Console.WriteLine(clonedWarrior1);
            Console.WriteLine(clonedWarrior2);
            Console.WriteLine(clonedMage1);
            Console.WriteLine(clonedMage2);

        }
    }
}
