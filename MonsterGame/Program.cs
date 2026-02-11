namespace MonsterGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetPlayerDetails getPlayerDetails = new GetPlayerDetails();
            string playerName = getPlayerDetails.GetPlayerName();

            // Hämta lösenord + skapa Player i en loop tills det blir giltigt
            Player player = null;

            while (player == null)
            {
                string playerPassword = getPlayerDetails.GetPlayerPassword();

                try
                {
                    // Create a new player
                    player = new Player(playerName, playerPassword);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Försök igen.\n");
                }
            }

            ushort playerAge = getPlayerDetails.GetPlayerAge();
            
            Console.WriteLine($"Player {player.PlayerName} has been created.");

            // Create a monster with 50 HP
            Monster monster = new Monster(50);

            // Create a weapon with 20 damage
            Weapon weapon = new Weapon(20);

            // Attack the monster three times
            weapon.Attack(monster);
            weapon.Attack(monster);
            weapon.Attack(monster);

            // The monster should die after the third attack (3 * 20 > 50!)
        }
    }
}
