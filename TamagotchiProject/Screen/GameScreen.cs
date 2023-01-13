using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class GameScreen:ScreenBase
    {
        public GameScreen() : base("game screen")
        {
        }
        public override void Show()
        {
            base.Show();

            Main.player.PastActions.Add(new PetAction("Played" ,Main.player.ActivePet));
            Console.WriteLine("press / to stop playing");
            char ch = Console.ReadKey().KeyChar;
            while (ch != '/')
            {
                Main.player.ActivePet.Play();
                if (ch == 'g')
                {
                    Main.player.ActivePet.Play();
                    Console.WriteLine($"YES {Main.player.Name}");
                }
                Console.WriteLine($"{Main.player.ActivePet.HappinessLevel}{}");
                ch = Console.ReadKey().KeyChar;
            }
        }

    }
}
