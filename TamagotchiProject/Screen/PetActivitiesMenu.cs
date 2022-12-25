using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Screen
{
    internal class PetActivitiesMenu:OptionScreen
    {
        public PetActivitiesMenu() : base("Pet Action Menu")
        {
            AddItem("Play", new GameScreen());
            AddItem("Clean", new CleaningScreen());
            AddItem("Feed", new FeedingScreen());
            AddItem("Pet History", new PetHistoryScreen());
            AddItem("Action History", new ActionHistoryScreen());
            AddItem("Pet Screen", new PetScreen());
        }
    }
}

