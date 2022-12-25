using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Data;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class SignUpScreen:ScreenBase
    {
        public string username;
        public string password;

        public SignUpScreen() : base("signup")
        {
        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("please enter username");
            username = Console.ReadLine();
            Console.WriteLine("please enter password");
            password = Console.ReadLine();
            AddNewPlayer();

            new NewPetScreen().Show();
        }


        private void AddNewPlayer()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
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
