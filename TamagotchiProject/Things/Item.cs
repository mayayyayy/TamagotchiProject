using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class Item
    {
        public string MenuTitle { get; set; }
        public ScreenBase Screen { get; set; }
        public Item() { }
        public Item(string title, ScreenBase screen)
        {
            MenuTitle = title;
            Screen = screen;
        }
    }
}

