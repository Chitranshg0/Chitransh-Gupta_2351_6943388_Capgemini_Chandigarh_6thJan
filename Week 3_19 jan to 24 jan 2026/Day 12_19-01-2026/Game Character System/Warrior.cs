using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Game_Character_System
{
    internal class Warrior : Character
    {
        public Warrior(string name) : base(name, 150, 20) { }

        public override void Attack(Character enemy)
        {
            int damage = attackPower + 10;
            enemy.TakeDamage(damage);
            Console.WriteLine($"{Name} swings sword for {damage} damage");
        }
    }
}
