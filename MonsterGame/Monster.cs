using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Monster
    {
        public int HP { get; set; }

        public Monster(int initialHP)
        {
            HP = initialHP;
        }

        // Method for the monster to take damage
        public void TakeDamage(int damage)
        {
            HP -= damage;

            // HP cant be less than 0!
            if (HP < 0) { HP = 0; }

            Console.WriteLine($"Monster takes {damage} damage. Remaining HP: {HP}");

            if (HP <= 0)
            {
                Die();
            }
        }

        // Method called when monster dies
        private void Die()
        {
            Console.WriteLine("The monster has died!");
        }
    }

}
