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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"\tenter username"}");
            Console.Write("\t");
            string user = Console.ReadLine();
            Console.WriteLine($"{"\tenter password"}");
            Console.Write("\t");
            string password = Console.ReadLine();
            while (Users.Login(user, password) == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"\tinvalid login. try again"}");
                Thread.Sleep(2000);
                Console.WriteLine($"{"\tenter username"}");
                Console.Write("\t");
                user = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"\tenter password"}");
                Console.Write("\t");
                password = Console.ReadLine();
            }

            Main.player = Users.Login(user, password);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tlogin successful");
            if (Main.player.ActivePet != null)
                new PetActivitiesMenu().Show();
            else
            {
                new NewPetScreen().Show();
                
            }
        }




    }
}

