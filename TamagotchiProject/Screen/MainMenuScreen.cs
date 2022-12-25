using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class MainMenuScreen:OptionScreen
    {
        public MainMenuScreen() : base("main menu")
        {
            Items = new List<Item>();
            AddItem(new Item("login ♥", new LoginScreen()));
            AddItem(new Item("sign up :D", new SignUpScreen()));
            AddItem(new Item("surprise ;)", new SurpriseScreen()));

        }
        public override void Show()
        {
            bool leave = false;
            while (!leave)
            {
                Main.player = null;
                base.Show();
                Choose(out leave);
            }

        }
    }
}
