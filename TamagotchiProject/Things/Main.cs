using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class Main
    {
        public static Player player;
        private ScreenBase Screen;

        public Main(ScreenBase wl)
        {
            this.Screen = wl;
        }
        public Main(Player p, ScreenBase y)
        {
            Screen = y;
            player = p;

        }
        public virtual void Start()
        {
            Screen.Show();
        }
    }
}
