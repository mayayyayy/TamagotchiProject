using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class Food
    {
        public static Dictionary<char, Food> foods = new Dictionary<char, Food>()
        {
            {'a', new Food("pple", 0.1, 0.05) },
            {'b', new Food("agel", 0.3, 0.2) },
            {'c', new Food("arrot", 0.15, 0.05) },
            {'d', new Food("onut", 0.2, 0.25) },
            {'e', new Food("gg", 0.1, 0.1) },
            {'f', new Food("ries", 0.3, 0.5) },
            {'g', new Food("ummy bears", 0.1, 0.25) },
            {'h', new Food("amburger", 0.6, 0.8) },
            {'i', new Food("ce cream", 0.3, 0.25) },
            {'j', new Food("ello", 0.2, 0.15) },
            {'k', new Food("iwi", 0.25, 0.05) },
            {'l', new Food("asasgna", 0.5, 0.4) },
            {'m', new Food("arshmallow", 0.1, 0.1) },
            {'n', new Food("achos", 0.4, 0.6) },
            {'o', new Food("reo", 0.15, 0.15) },
            {'p', new Food("izza", 0.4, 0.55) },
            {'q', new Food("uiche", 0.3, 0.25) },
            {'r', new Food("ick astley", 0.6, 0.7) },
            {'s', new Food("teak", 0.7, 0.45) },
            {'t', new Food("aco", 0.55, 0.5) },
            {'u', new Food("mbrella", -1, 0) },
            {'v', new Food("anilla extract", 0, 0.1) },
            {'w', new Food("affle", 0.45, 0.35) },
            {'x', new Food("ylophone", -1, 0) },
            {'y', new Food("ogurt", 0.2, 0.15) },
            {'z', new Food("ebra", 1, 1) }
        };
        public string Name { get; private set; }
        public double FillingLevel { get; private set; }
        public double WeightGain { get; private set; }
        public Food(string name, double fillingLevel, double weightAdd)
        {
            Name = name;
            FillingLevel = fillingLevel;
            WeightGain = weightAdd;
        }
    }
}

