using System;

namespace AprilNine.Models
{
    public enum Lowcal
    {
        Chips, Fruit, Cookie
    }
    public class Snack
    {
        public Guid ID { get; set; }
       
       
        public Lowcal Treat { get; set;}

    }
}