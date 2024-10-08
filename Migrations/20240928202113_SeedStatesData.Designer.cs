﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nigeria.Data;

#nullable disable

namespace nigeria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240928202113_SeedStatesData")]
    partial class SeedStatesData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("nigeria.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Area")
                        .HasColumnType("double");

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Governor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 1171.0,
                            Capital = "Ikeja",
                            Governor = "Babajide Sanwo-Olu",
                            Name = "Lagos",
                            Population = 14210000L,
                            Region = "South-West"
                        },
                        new
                        {
                            Id = 2,
                            Area = 20131.0,
                            Capital = "Kano",
                            Governor = "Abba Kabir Yusuf",
                            Name = "Kano",
                            Population = 11037920L,
                            Region = "North-West"
                        },
                        new
                        {
                            Id = 3,
                            Area = 4844.0,
                            Capital = "Awka",
                            Governor = "Charles Chukwuma Soludo",
                            Name = "Anambra",
                            Population = 5612000L,
                            Region = "South-East"
                        },
                        new
                        {
                            Id = 4,
                            Area = 11077.0,
                            Capital = "Port Harcourt",
                            Governor = "Siminalayi Fubara",
                            Name = "Rivers",
                            Population = 7191000L,
                            Region = "South-South"
                        },
                        new
                        {
                            Id = 5,
                            Area = 28454.0,
                            Capital = "Ibadan",
                            Governor = "Seyi Makinde",
                            Name = "Oyo",
                            Population = 7800000L,
                            Region = "South-West"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
