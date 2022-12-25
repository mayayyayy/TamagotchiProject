using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
     class PetHistoryScreen:ScreenBase
    {
        public PetHistoryScreen() : base("Pet History Screen") { }
        public override void Show()
        {
            base.Show();
            Player player = Main.player;
            if (!(player.PastPets is null))
            {
                Console.WriteLine("Your past pets:");
                foreach (Pet pet in player.PastPets)
                {
                    Console.WriteLine($"{pet.Name}: {pet.CreationTime}-{pet.DeathTime}");
                }
            }
            else Console.WriteLine("You must first have had at least one pet");
            Console.ReadKey();
        }
    }
}

