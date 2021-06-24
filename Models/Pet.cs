using System;

namespace TamagotchiAPI.Models
{

    public class Pet
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HungerLevel { get; set; } = 0;

        public int HappinessLevel { get; set; } = 0;

        public DateTime LastInteractedWithDate { get; set; } = DateTime.Now;

        public bool IsDead { get; set; } = false;


        public void UpdatePet()
        {
            if ((this.LastInteractedWithDate - DateTime.Now).TotalDays > 3)
            {
                this.IsDead = true;
            }

        }
    }
}