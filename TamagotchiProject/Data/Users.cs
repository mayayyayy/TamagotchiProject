using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Data
{
    public class Users
    {
        private static List<Player> players = new List<Player>() { new Player("maya", "2929", "maya") };

        public static Player Login(string user, string pword)
        {
            return players.FirstOrDefault(x => x.Username == user && x.Password == pword);
        }

        internal static void Save(Player p)
        {
            players[players.FindIndex(x => x.Username == p.Username)] = p;

        }
        public static void New(Player p)
        {
            if (players.Find(x => x.Username == p.Username) != null)
            {
                Save(p);
                return;
            }
            players.Add(p);
        }
    }
}
