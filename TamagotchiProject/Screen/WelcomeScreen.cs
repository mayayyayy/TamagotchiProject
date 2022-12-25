using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Things;

namespace TamagotchiProject.Screen
{
    public class WelcomeScreen:ScreenBase
    {
        public WelcomeScreen() : base("\r\n.--.      .--.    .-''-.    .---.        _______      ,-----.    ,---.    ,---.    .-''-.   \r\n|  |_     |  |  .'_ _   \\   | ,_|       /   __  \\   .'  .-,  '.  |    \\  /    |  .'_ _   \\  \r\n| _( )_   |  | / ( ` )   ',-./  )      | ,_/  \\__) / ,-.|  \\ _ \\ |  ,  \\/  ,  | / ( ` )   ' \r\n|(_ o _)  |  |. (_ o _)  |\\  '_ '`)  ,-./  )      ;  \\  '_ /  | :|  |\\_   /|  |. (_ o _)  | \r\n| (_,_) \\ |  ||  (_,_)___| > (_)  )  \\  '_ '`)    |  _`,/ \\ _/  ||  _( )_/ |  ||  (_,_)___| \r\n|  |/    \\|  |'  \\   .---.(  .  .-'   > (_)  )  __: (  '\\_/ \\   ;| (_ o _) |  |'  \\   .---. \r\n|  '  /\\  `  | \\  `-'    / `-'`-'|___(  .  .-'_/  )\\ `\"/  \\  ) / |  (_,_)  |  | \\  `-'    / \r\n|    /  \\    |  \\       /   |        \\`-'`-'     /  '. \\_/``\".'  |  |      |  |  \\       /  \r\n`---'    `---`   `'-..-'    `--------`  `._____.'     '-----'    '--'      '--'   `'-..-'   \r\n                                                                                            \r\n")
        {

        }

        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            base.Show();
            Console.ReadKey();

            MainMenuScreen next = new MainMenuScreen();
            next.Show();
        }
    }
}
