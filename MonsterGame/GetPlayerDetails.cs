using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class GetPlayerDetails
    {
        public string GetPlayerName() 
        {
            Console.WriteLine("What is the name of your hero?");
            return Console.ReadLine();
        }

        public string GetPlayerPassword()
        {
            Console.WriteLine("What is your password? (at least 8 characters!)");
            return Console.ReadLine();
        }

        public ushort GetPlayerAge()
        {
            try
            {
                Console.WriteLine("How old is your hero?");
                return Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // If incorrect age is entered create a player with age 0!
                return 0;
            }
        }
    }
}
