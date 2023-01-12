using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiProject.Things
{
    public class PetAction
    {
        public string description { get;private set; }
        public Pet pet { get; private set; }
        public DateTime Time { get; private set; }

        public PetAction(string description, Pet pet, DateTime time)
        {
            this.description = description;
            this.pet = pet;
            Time = time;
        }
        public PetAction(string description, Pet pet)
        {
            Time = DateTime.Now;
            this.description = description;
            this.pet = pet;
        }
        public override string ToString()
        {
            return $"{description} {pet.Name} on {Time}";
        }
    }
}
