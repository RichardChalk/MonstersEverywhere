using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                throw new ArgumentException("Password must be at least 8 characters long, contain at least one capital letter, and at least one number.");
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
