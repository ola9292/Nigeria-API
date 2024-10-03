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
            },
            new State
            {
            Id = 6,
            Name = "Abia",
            Capital = "Umuahia",
            Population = 3643000,
            Area = 6320,
            Region = "South-East",
            Governor = "Okezie Ikpeazu"
        },
        new State
        {
            Id = 7,
            Name = "Adamawa",
            Capital = "Yola",
            Population = 4485000,
            Area = 36917,
            Region = "North-East",
            Governor = "Ahmadu Umaru Fintiri"
        },
        new State
        {
            Id = 8,
            Name = "Akwa Ibom",
            Capital = "Uyo",
            Population = 5540000,
            Area = 7081,
            Region = "South-South",
            Governor = "Umo Eno"
        },
        new State
        {
            Id = 9,
            Name = "Anambra",
            Capital = "Awka",
            Population = 5612000,
            Area = 4844,
            Region = "South-East",
            Governor = "Charles Chukwuma Soludo"
        },
        new State
        {
            Id = 10,
            Name = "Bauchi",
            Capital = "Bauchi",
            Population = 6555000,
            Area = 45837,
            Region = "North-East",
            Governor = "Bala Mohammed"
        },
        new State
        {
            Id = 11,
            Name = "Bayelsa",
            Capital = "Yenagoa",
            Population = 2325000,
            Area = 10773,
            Region = "South-South",
            Governor = "Douye Diri"
        },
        new State
        {
            Id = 12,
            Name = "Benue",
            Capital = "Makurdi",
            Population = 5339000,
            Area = 34059,
            Region = "North-Central",
            Governor = "Hyacinth Alia"
        },
        new State
        {
            Id = 13,
            Name = "Borno",
            Capital = "Maiduguri",
            Population = 5883000,
            Area = 70698,
            Region = "North-East",
            Governor = "Babagana Umara Zulum"
        },
        new State
        {
            Id = 14,
            Name = "Cross River",
            Capital = "Calabar",
            Population = 3785000,
            Area = 20156,
            Region = "South-South",
            Governor = "Bassey Otu"
        },
        new State
        {
            Id = 15,
            Name = "Delta",
            Capital = "Asaba",
            Population = 5714000,
            Area = 17898,
            Region = "South-South",
            Governor = "Sheriff Oborevwori"
        },
        new State
        {
            Id = 16,
            Name = "Ebonyi",
            Capital = "Abakaliki",
            Population = 2905000,
            Area = 5533,
            Region = "South-East",
            Governor = "Francis Nwifuru"
        },
        new State
        {
            Id = 17,
            Name = "Edo",
            Capital = "Benin City",
            Population = 4705000,
            Area = 17802,
            Region = "South-South",
            Governor = "Godwin Obaseki"
        },
        new State
        {
            Id = 18,
            Name = "Ekiti",
            Capital = "Ado Ekiti",
            Population = 3314000,
            Area = 6353,
            Region = "South-West",
            Governor = "Biodun Oyebanji"
        },
        new State
        {
            Id = 19,
            Name = "Enugu",
            Capital = "Enugu",
            Population = 4354000,
            Area = 7161,
            Region = "South-East",
            Governor = "Peter Mbah"
        },
        new State
        {
            Id = 20,
            Name = "Gombe",
            Capital = "Gombe",
            Population = 3102000,
            Area = 18768,
            Region = "North-East",
            Governor = "Inuwa Yahaya"
        },
        new State
        {
            Id = 21,
            Name = "Imo",
            Capital = "Owerri",
            Population = 5410000,
            Area = 5530,
            Region = "South-East",
            Governor = "Hope Uzodinma"
        },
        new State
        {
            Id = 22,
            Name = "Jigawa",
            Capital = "Dutse",
            Population = 5533000,
            Area = 23154,
            Region = "North-West",
            Governor = "Umar Namadi"
        },
        new State
        {
            Id = 23,
            Name = "Kaduna",
            Capital = "Kaduna",
            Population = 8117000,
            Area = 46053,
            Region = "North-West",
            Governor = "Uba Sani"
        },
        new State
        {
            Id = 24,
            Name = "Katsina",
            Capital = "Katsina",
            Population = 8418000,
            Area = 24192,
            Region = "North-West",
            Governor = "Dikko Radda"
        },
        new State
        {
            Id = 25,
            Name = "Kebbi",
            Capital = "Birnin Kebbi",
            Population = 4418000,
            Area = 36800,
            Region = "North-West",
            Governor = "Nasir Idris"
        },
        new State
        {
            Id = 26,
            Name = "Kogi",
            Capital = "Lokoja",
            Population = 4388000,
            Area = 29333,
            Region = "North-Central",
            Governor = "Yahaya Bello"
        },
        new State
        {
            Id = 27,
            Name = "Kwara",
            Capital = "Ilorin",
            Population = 3361000,
            Area = 36825,
            Region = "North-Central",
            Governor = "AbdulRahman AbdulRazaq"
        },
        new State
        {
            Id = 28,
            Name = "Nasarawa",
            Capital = "Lafia",
            Population = 2438000,
            Area = 27117,
            Region = "North-Central",
            Governor = "Abdullahi Sule"
        },
        new State
        {
            Id = 29,
            Name = "Niger",
            Capital = "Minna",
            Population = 5384000,
            Area = 76363,
            Region = "North-Central",
            Governor = "Mohammed Umaru Bago"
        },
        new State
        {
            Id = 30,
            Name = "Ogun",
            Capital = "Abeokuta",
            Population = 4968000,
            Area = 16762,
            Region = "South-West",
            Governor = "Dapo Abiodun"
        },
        new State
        {
            Id = 31,
            Name = "Ondo",
            Capital = "Akure",
            Population = 4733000,
            Area = 15500,
            Region = "South-West",
            Governor = "Rotimi Akeredolu"
        },
        new State
        {
            Id = 32,
            Name = "Osun",
            Capital = "Oshogbo",
            Population = 4202000,
            Area = 9251,
            Region = "South-West",
            Governor = "Ademola Adeleke"
        },
        new State
        {
            Id = 33,
            Name = "Plateau",
            Capital = "Jos",
            Population = 4823000,
            Area = 30609,
            Region = "North-Central",
            Governor = "Caleb Mutfwang"
        },
        new State
        {
            Id = 34,
            Name = "Sokoto",
            Capital = "Sokoto",
            Population = 5106000,
            Area = 25832,
            Region = "North-West",
            Governor = "Ahmed Aliyu"
        },
        new State
        {
            Id = 35,
            Name = "Taraba",
            Capital = "Jalingo",
            Population = 3386000,
            Area = 54473,
            Region = "North-East",
            Governor = "Agbu Kefas"
        },
        new State
        {
            Id = 36,
            Name = "Yobe",
            Capital = "Damaturu",
            Population = 2922000,
            Area = 45863,
            Region = "North-East",
            Governor = "Mai Mala Buni"
        },
        new State
        {
            Id = 37,
            Name = "Zamfara",
            Capital = "Gusau",
            Population = 4876000,
            Area = 39262,
            Region = "North-West",
            Governor = "Dauda Lawal"
        }
        );
    }
}
