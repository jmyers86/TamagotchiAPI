using System;
using System.Timers;

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

        public DateTime LastTimeFed { get; set; } = DateTime.Now;

        public bool IsDead { get; set; } = false;


        public void UpdatePet()
        {
            if ((this.LastInteractedWithDate - DateTime.Now).TotalDays > 3)
            {
                this.IsDead = true;
            }

        }
        public void UpdateHungerAndHappiness()
        {
            if ((this.LastTimeFed - DateTime.Now).TotalMinutes > 1)
            {
                this.HungerLevel = HungerLevel - Convert.ToInt32((this.LastTimeFed - DateTime.Now).TotalMinutes);
                this.HappinessLevel = HappinessLevel - Convert.ToInt32((this.LastTimeFed - DateTime.Now).TotalMinutes);
            }

            // this.HungerLevel = HungerLevel - Convert.ToInt32((this.LastTimeFed - DateTime.Now).TotalDays);
            // this.HappinessLevel = HappinessLevel - Convert.ToInt32((this.LastTimeFed - DateTime.Now).TotalDays);


        }
    }
}