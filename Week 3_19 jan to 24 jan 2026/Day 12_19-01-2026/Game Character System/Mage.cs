using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Game_Character_System
{
    internal class Mage : Character
    {
        public Mage(string name) : base(name, 100, 30) { }

        public override void Attack(Character enemy)
        {
            int damage = attackPower + 15;
            enemy.TakeDamage(damage);
            Console.WriteLine($"{Name} casts fireball for {damage} damage");
        }
    }
}
