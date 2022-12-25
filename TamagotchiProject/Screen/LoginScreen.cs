using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TamagotchiProject.Data;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class LoginScreen:ScreenBase
    {
        public LoginScreen() : base("login")
        {

        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{"\tenter username"}");
            Console.Write("\t");
            string user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{"\tenter password"}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t");
            string password = Console.ReadLine();
            while (Main.player.Password != password || Main.player.Username != user)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"\tinvalid login. try again"}");
                Thread.Sleep(2000);
                Show();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tlogin successful");
            if (Main.player.ActivePet != null)
                new PetScreen().Show();
            else
                new NewPetScreen().Show();
            ScreenBase next = new PetScreen();
            Console.ResetColor();
            next.Show(); base.Show();
            Console.WriteLine("press any key to sign out", 15);

        }

        private Player Login(string user, string password)
        {
            return Users.Login(user, password);
        }



    }
}

