using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class ScreenBase
    {
        protected string Title { get; set; }
        public ScreenBase(string title)
        {
            this.Title = title;
        }
        public virtual void Show()
        {
            Console.WriteLine("pls give us 100");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Title,65}");
        }
    }
}
