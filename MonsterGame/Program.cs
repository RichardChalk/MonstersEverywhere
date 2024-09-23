namespace MonsterGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetPlayerDetails getPlayerDetails = new GetPlayerDetails();
            string playerName = getPlayerDetails.GetPlayerName();
            string playerPassword = getPlayerDetails.GetPlayerPassword();
            ushort playerAge = getPlayerDetails.GetPlayerAge();
            
            // Create a new player
            Player player = new Player(playerName, playerPassword);

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
