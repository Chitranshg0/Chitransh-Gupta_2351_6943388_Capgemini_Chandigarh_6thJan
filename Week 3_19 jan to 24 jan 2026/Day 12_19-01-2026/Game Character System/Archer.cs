using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Game_Character_System
{
    internal class Archer : Character 
    {
        public Archer(string name) : base(name, 120, 25) { }

        public override void Attack(Character enemy)
        {
            int damage = attackPower + 5;
            enemy.TakeDamage(damage);
            Console.WriteLine($"{Name} shoots arrow for {damage} damage");
        }
    }
}
