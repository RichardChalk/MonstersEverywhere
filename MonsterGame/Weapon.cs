using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Weapon
    {
        public int Damage { get; set; }

        public Weapon(int damage)
        {
            Damage = damage;
        }

        // Method to attack a monster
        public void Attack(Monster monster)
        {
            Console.WriteLine("Attacking the monster...");
            monster.TakeDamage(Damage);
        }
    }
}
