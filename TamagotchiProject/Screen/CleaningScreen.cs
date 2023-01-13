using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class CleaningScreen:ScreenBase
    {
        private Pet pet;
        public CleaningScreen() : base($"Clean {Main.player.ActivePet.Name}")
        {
            pet = Main.player.ActivePet;
        }

        public override void Show()
        {
            base.Show();
            Main.player.PastActions.Add(new PetAction("Cleaned", pet));
            Console.WriteLine("Press keys to clean");
            while (pet.CleanlinessLevel < 100)
            {
                Console.ReadKey();
                Console.WriteLine("");
                pet.Clean();
            }
            Console.WriteLine($"{pet.Name} is clean!");

            Console.ReadKey();
        }
    }
}
