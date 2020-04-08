using AprilNine.Models;
using Microsoft.EntityFrameworkCore;

namespace AprilNine.Data
{
    //Creates a new database context named StudentInformationContext
    public class AprilNineContext : DbContext
    {
        public AprilNineContext(DbContextOptions<AprilNineContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Game> Games { get; set; }

        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<Snack> Snacks { get; set; }
    }
}