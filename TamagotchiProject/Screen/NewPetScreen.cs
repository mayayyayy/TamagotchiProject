using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class NewPetScreen:ScreenBase
    {
        public NewPetScreen() : base("create new pet") { }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("Enter pet name");
            string name = Console.ReadLine();

            Main.player.ActivePet = new Pet(name);

            new PetActivitiesMenu().Show();
        }
    }
}

