using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public Pet ActivePet { get; set; }
        public List<Pet> PastPets { get; private set; }
        public List<PetAction> PastActions { get; private set; }

        private static List<Player> players = new List<Player>();
        public bool FindPlayer(Player p)
        {
            return players.Contains(p);
        }
        public Player(string username, string password, string name)
        {
            Username = username;
            Password = password;
            Name = name;
            PastActions = new List<PetAction>();
            PastPets = new List<Pet>();
        }

        public Player(string username, string password, string name, Pet activePet, List<Pet> pastPets, List<PetAction> pastActions)
        {
            Username = username;
            Password = password;
            Name = name;
            ActivePet = activePet;
            PastPets = pastPets;
            PastActions = pastActions;
        }
    }
}
