namespace MonsterGame
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string Password { get; set; }

        public Player(string playerName, string pw)
        {
            PlayerName = playerName;

            if (IsValidPassword(pw))
            {
                Password = pw;
            }
            else
            {
                throw new ArgumentException("Password must be at least 8 characters long!");
            }
        }


        // Password validation method
        private bool IsValidPassword(string pwd)
        {
            if (pwd.Length < 8)
                return false;

            return true;
        }
    }
}
