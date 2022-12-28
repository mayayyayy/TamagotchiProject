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
            while (Console.ReadKey().KeyChar != '/')
            {
                Main.player.ActivePet.Play();
                Console.WriteLine(Main.player.ActivePet.HappinessLevel);
            }
        }

    }
}
