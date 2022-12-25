using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class PetScreen:ScreenBase
    {
        private Pet pet;
        public PetScreen() : base($"view {Main.player.ActivePet.Name}")
        {
            pet = Main.player.ActivePet;
        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine($"{pet.Name} Weight: {pet.Weight}");
            Console.WriteLine($"{pet.Name} Age: {pet.Age}");
            Console.WriteLine($"{pet.Name} Health Status: {pet.HealthStatus}");
            Console.WriteLine($"{pet.Name} Hunger Level: {pet.HungerLevel}");
            Console.WriteLine($"{pet.Name} Cleanliness Level: {pet.CleanlinessLevel}");
            Console.WriteLine($"{pet.Name} Happiness Level: {pet.HappinessLevel}");

            Console.WriteLine("\ncontinue to choosing activities");
            Console.ReadKey();
            new PetActivitiesMenu().Show();
        }
    }
}
