using System;

namespace AprilNine.Models
{
    public enum MorningGame
    {
        Computer, Basketball, Soccer
    }
    public class Game
    {
        public Guid ID { get; set; }
               
        public MorningGame FunTime1 { get; set;}
        public MorningGame FunTime2 { get; set;}

    }
}