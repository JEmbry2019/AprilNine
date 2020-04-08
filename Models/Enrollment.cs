using System;

namespace AprilNine.Models
{
    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid GameID { get; set; }
        public Guid CamperID { get; set; }
        public Guid BreakfastID { get; set; }
        public Guid LunchID { get; set; }
        public Guid SnackID { get; set; }
        

        public Game Game { get; set; }
        public Camper Camper { get; set; }
        public Breakfast Breakfast { get; set; }
        public Lunch Lunch { get; set; }
         public Snack Snack { get; set; }

    }
}