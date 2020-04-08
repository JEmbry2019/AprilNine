using System;

namespace AprilNine.Models
{
    public enum MorningMeal
    {
        Cereal, Eggs, Burrito
    }
    public class Breakfast
    {
        public Guid ID { get; set; }
       
        public MorningMeal Morning { get; set;}

    }
}