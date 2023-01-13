using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TamagotchiProject.Data;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class SignUpScreen:ScreenBase
    {
        public SignUpScreen() : base("signup") { }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("please enter username");
            string username = Console.ReadLine();
            Console.WriteLine("please enter password");
            string password = Console.ReadLine();
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            AddNewPlayer(username, password, name);

            new NewPetScreen().Show();
        }


        private void AddNewPlayer(string username, string password, string name)
        {
            try
            {
                Main.player = new Player(username, password, name);
                Users.New(Main.player);

            }
            catch (Exception)
            {
                Console.WriteLine("oopsie");
            }
        }
    }
}
