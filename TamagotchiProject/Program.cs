using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TamagotchiProject.Screen;
using TamagotchiProject.Things;

namespace TamagotchiProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(TIME));
            t.Start();
            Main app = new Main(new WelcomeScreen());
            app.Start();
            t.Abort();
        }
        static void TIME()
        {
            int hungerCounter = 0;
            while (true)
            {
                if (!(Things.Main.player is null))
                {
                    if (!(Things.Main.player.ActivePet is null))    
                    {
                        Pet p = Things.Main.player.ActivePet;
                        p.HungerLevel += 5;
                        p.DecreaseHappiness(15);

                        if (p.HungerLevel >= 80)
                        {
                            hungerCounter++;
                            if (hungerCounter > 15)
                                p.GetSicker("Hunger");
                            hungerCounter++;
                        }
                        else
                            hungerCounter = 0;
                    }
                }
                Thread.Sleep(2000);
            }
        }
    }
}
