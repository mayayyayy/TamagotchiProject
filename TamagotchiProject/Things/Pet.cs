using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiProject.Screen;

namespace TamagotchiProject.Things
{
    public class Pet
    {
        private static string[] FoodReactions = { "yum", "eww", "meh", "more" };
        public static readonly List<string> HealthStati = new List<string>() { "Healthy", "Sick", "Dying", "Dead" };

        public DateTime CreationTime { get; private set; }
        public DateTime DeathTime { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string HealthStatus { get; set; }
        public Dictionary<Food, string> FoodsToReactions { get; private set; }

        //Levels are from 0 - 1
        private double hungerLevel;
        private double cleanlinessLevel;
        private double happinessLevel;

        #region Accessors
        public double HungerLevel
        {
            get { return hungerLevel; }
            set
            {
                hungerLevel = value;
                if (hungerLevel >= 1)
                    hungerLevel = 1;
                if (hungerLevel <= 0)
                    hungerLevel = 0;
            }
        }
        public double CleanlinessLevel
        {
            get { return cleanlinessLevel; }
            set
            {
                cleanlinessLevel = value;
                if (cleanlinessLevel >= 1)
                    cleanlinessLevel = 1;
                if (cleanlinessLevel <= 0)
                    cleanlinessLevel = 0;
            }
        }

        //as a function that only approaches 1
        private static double A = 0.5;
        public double HappinessLevel
        {
            get
            {
                return happinessLevel / (happinessLevel + A);
            }
            set
            {
                if (value <= 0)
                    happinessLevel = 0;
                else
                    //happinessLevel = A / (1 / value - 1);
                    happinessLevel = value;
            }
        }
        #endregion
        public Pet(string name)
        {
            Name = name;

            CreationTime = DateTime.Now;
            Weight = 4;
            Age = 0;
            HealthStatus = HealthStati[0];
            HungerLevel = 0.4;
            CleanlinessLevel = 0.2;
            HappinessLevel = 0.2;

            //map foods to reactions
            Random r = new Random();
            FoodsToReactions = new Dictionary<Food, string>();
            foreach (KeyValuePair<char, Food> f in Food.foods)
            {
                FoodsToReactions.Add(f.Value, FoodReactions[r.Next(0, FoodReactions.Length)]);
            }
        }

        #region Actions
        public void Feed(Food food)
        {
            Console.WriteLine(food.Name);
            Console.WriteLine(FoodsToReactions[food]);
            Weight += food.WeightGain;
            HungerLevel -= food.FillingLevel;

            if (food.FillingLevel == -1)
            {
                Die($"eating a {food.Name}");
            }

        }
        public void Clean()
        {
            CleanlinessLevel += 0.2;
            Console.WriteLine("*scrub*");
        }
        public void Play()
        {
            HappinessLevel += 0.2;
            Console.WriteLine(":)");
        }
        public void Die()
        {
            DeathTime = DateTime.Now;
            HealthStatus = HealthStati[HealthStati.Count - 1];
            Main.player.PastPets.Add(this);
            Main.player.ActivePet = null;
            Console.WriteLine("create a new pet");
            Console.ReadKey();
            new NewPetScreen().Show();
        }
        public void Die(string reason)
        {
            Console.WriteLine($"{Name} died because of {reason}");
            Die();
        }

        public void GetSicker(string reason) //זה לא באמת פעולת גט תרגע אוהד
        {
            int index = HealthStati.FindIndex(x => x == HealthStatus);
            if (index <= 0) Die(reason);
            else HealthStatus = HealthStati[index - 1];                
        }
        #endregion
    }
}

