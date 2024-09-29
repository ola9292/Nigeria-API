namespace nigeria.Data;
using nigeria.Models;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<State> States { get; set; } // The 'States' table in the database

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed the States table with initial data
        modelBuilder.Entity<State>().HasData(
            new State
            {
                Id = 1,
                Name = "Lagos",
                Capital = "Ikeja",
                Population = 14210000,
                Area = 1171, // in square kilometers
                Region = "South-West",
                Governor = "Babajide Sanwo-Olu"
            },
            new State
            {
                Id = 2,
                Name = "Kano",
                Capital = "Kano",
                Population = 11037920,
                Area = 20131,
                Region = "North-West",
                Governor = "Abba Kabir Yusuf"
            },
            new State
            {
                Id = 3,
                Name = "Anambra",
                Capital = "Awka",
                Population = 5612000,
                Area = 4844,
                Region = "South-East",
                Governor = "Charles Chukwuma Soludo"
            },
            new State
            {
                Id = 4,
                Name = "Rivers",
                Capital = "Port Harcourt",
                Population = 7191000,
                Area = 11077,
                Region = "South-South",
                Governor = "Siminalayi Fubara"
            },
            new State
            {
                Id = 5,
                Name = "Oyo",
                Capital = "Ibadan",
                Population = 7800000,
                Area = 28454,
                Region = "South-West",
                Governor = "Seyi Makinde"
            }
        );
    }
}
