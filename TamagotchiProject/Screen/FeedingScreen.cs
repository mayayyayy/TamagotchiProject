using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class FeedingScreen:ScreenBase
    {
        private Pet pet;
        public FeedingScreen() : base("feeding screen")
        {
            pet = Main.player.ActivePet;
        }

        public override void Show()
        {
            base.Show();
            Main.player.PastActions.Add($"Fed {pet.Name} at {DateTime.Now}");
            while (pet.HungerLevel > 0)
            {
                char ch = Console.ReadKey().KeyChar;
                if (ch >= 'a' && ch <= 'z')
                {
                    pet.Feed(Food.foods[ch]);
                    pet.CleanlinessLevel -= 0.15;
                }
                else
                    Console.WriteLine($"i don't have a food that starts with {ch}");
            }
            Console.WriteLine($"{pet.Name} is full!");
            Console.ReadKey();

            new PetScreen().Show();
        }
    }
}


