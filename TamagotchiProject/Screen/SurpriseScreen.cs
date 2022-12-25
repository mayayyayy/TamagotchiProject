using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    internal class SurpriseScreen:ScreenBase
    {
        public SurpriseScreen() : base("SURPRISE") { }
        public override void Show()
        {
            base.Show();
            string target = "https://www.youtube.com/watch?v=xvFZjo5PgG0";
            System.Diagnostics.Process.Start(target);
        }

    }
}

