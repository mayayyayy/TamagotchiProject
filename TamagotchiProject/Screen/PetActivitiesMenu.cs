using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    internal class PetActivitiesMenu:OptionScreen
    {
        public List<string> verydumb;
        public PetActivitiesMenu() : base("Pet Action Menu")
        {
            AddItem("Play", new GameScreen());
            AddItem("Clean", new CleaningScreen());
            AddItem("Feed", new FeedingScreen());
            AddItem("Pet History", new PetHistoryScreen());
            AddItem("Action History", new ActionHistoryScreen());
            verydumb = new List<string>();
                
        }
        public void Update()
        {
            Pet pet = Main.player.ActivePet;
            if (pet.HealthStatus == Pet.HealthStati[Pet.HealthStati.Count - 1])
                Console.ForegroundColor = ConsoleColor.DarkRed;
            verydumb.RemoveRange(0,verydumb.Count);
            verydumb.Add($"Weight: {pet.Weight}");
            verydumb.Add($"Age: {pet.Age}");
            verydumb.Add($"Health Status: {pet.HealthStatus}");
            verydumb.Add($"Hunger Level: {pet.HungerLevel}");
            verydumb.Add($"Cleanliness Level: {pet.CleanlinessLevel}");
            verydumb.Add($"Happiness Level: {pet.HappinessLevel}");
        }

        public override void Show()
        {
            bool leave = false;
            while (!leave)
            {
                base.Show();
                Update();
                int[] c = {Console.CursorTop, Console.CursorLeft};
                if(!(verydumb is null)){
                    Console.CursorTop = 1;
                    foreach(string s in verydumb){
                        Console.CursorTop++;
                        Console.CursorLeft = 30;
                        Console.WriteLine(s);
                    }
                }
                Console.CursorTop = c[0];
                Console.CursorLeft = c[1];

                Choose(out leave);
            }
        }
    }
}

