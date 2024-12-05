using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDemo.Classes
{
    public class Character
    {
        public string Name { get; }
        public int Level { get; private set; }
        public int Health { get; private set; }

        public Character(string name, int health)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be null or empty.");
            if (health <= 0) throw new ArgumentException("Health must be greater than zero.");

            Name = name;
            Level = 1;
            Health = health;
        }

        public void LevelUp()
        {
            Level++;
            Health += 10; // Ganha 10 de vida ao subir de nível.
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0) throw new ArgumentException("Damage cannot be negative.");
            Health -= damage;

            if (Health < 0) Health = 0; // Vida mínima é 0.
        }

        public bool IsAlive => Health > 0;
    }
}
