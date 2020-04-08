using System;


namespace AprilNine.Models
{
    public enum LunchMeal
    {
        Hotdog, Burger, Salad
    }
    public class Lunch
    {
        public Guid ID { get; set; }
       
        public LunchMeal Noon { get; set;}

    }
}