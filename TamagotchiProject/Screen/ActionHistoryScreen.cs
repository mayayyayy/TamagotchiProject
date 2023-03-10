using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
     class ActionHistoryScreen:ScreenBase
     {
        public ActionHistoryScreen() : base("Action History") { }
        public override void Show()
        {
            base.Show();
            foreach (PetAction a in Main.player.PastActions)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
