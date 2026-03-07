using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System
{
    internal class Character
    {
        private int level = 1;
        protected int health;
        protected int attackPower;

        public string Name { get; private set; }
        public int Health => health;

        public Character(string name, int health, int attack)
        {
            Name = name;
            this.health = health;
            attackPower = attack;
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
        }

        public virtual void Attack(Character enemy)
        {
            enemy.TakeDamage(attackPower);
            Console.WriteLine($"{Name} attacks {enemy.Name} for {attackPower} damage");
        }

        public void LevelUp()
        {
            level++;
            health += 20;
            attackPower += 5;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} | Health: {health}");
        }
    }
}
