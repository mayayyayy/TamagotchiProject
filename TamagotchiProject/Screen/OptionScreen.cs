using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class OptionScreen:ScreenBase
    {
        public List<Item> Items { get; protected set; }

        public OptionScreen(string title) : base(title)
        {
            Items = new List<Item>();
            if (Main.player != null)
                AddItem("sign out", new WelcomeScreen());
        }

        public void AddItem(Item i)
        {
            Items.Add(i);
        }
        public void AddItem(string title, ScreenBase screen)
        {
            Items.Add(new Item(title, screen));
        }

        public override void Show()
        {
            bool leave = false;
            while (!leave)
            {
                base.Show();
                Console.WriteLine($"choose (1 - {Items.Count()}):");
                for (int i = 0; i < Items.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}: {Items[i].MenuTitle}");
                }
                int option;
                while (!(int.TryParse(Console.ReadLine(), out option)))
                {
                    Console.WriteLine("try again bruh");
                }

                if (option >= 1 && option <= Items.Count())
                {
                    leave = true;
                    Items[option - 1].Screen.Show();
                }
            }
        }
    }
}
