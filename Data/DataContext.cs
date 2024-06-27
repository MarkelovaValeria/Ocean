using Microsoft.EntityFrameworkCore;
using Ocean.Data.Models;

namespace Ocean.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ShoppingBasket> ShoppingBaskets { get;set; }
        public DbSet<Employers> Employers { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserName).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Surname).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Password).IsRequired().HasMaxLength(8);
            entity.HasMany(e => e.Orders).WithOne(e => e.Users).HasForeignKey(e => e.UsersId).IsRequired(false);
        });
            modelBuilder.Entity<Employers>().HasData(
                new Employers { Id = 1, FullName = "Catherine Shevchenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/1.jpeg" },
                new Employers { Id = 2, FullName = "Matthew Tkachenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/2.jpeg" },
                new Employers { Id = 3, FullName = "Lilia Petrenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/3.jpeg" },
                new Employers { Id = 4, FullName = "Martin Goncharenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/4.jpeg" }
                );

            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    Id = 1,
                    AnimalName = "Stonefish",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 3,
                    PathPhoto = "/images/Animal/new2.png"
                },
                new Animal
                {
                    Id = 2,
                    AnimalName = "Sea angel",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 5,
                    PathPhoto = "/images/Animal/3new.png"
                },
                new Animal
                {
                    Id = 3,
                    AnimalName = "Lion fish",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 4,
                    PathPhoto = "/images/Animal/new4.png"
                },
                new Animal
                {
                    Id = 4,
                    AnimalName = "Hammerhead",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 4,
                    PathPhoto = "/images/Animal/new5.png"
                },
                new Animal
                {
                    Id = 5,
                    AnimalName = "Fugu fish",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 4,
                    PathPhoto = "/images/Animal/new6.png"
                },
                new Animal
                {
                    Id = 6,
                    AnimalName = "Whale",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 4,
                    PathPhoto = "/images/Animal/new7.png"
                },
                new Animal
                {
                    Id = 7,
                    AnimalName = "Dumbo octopus",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 5,
                    PathPhoto = "/images/Animal/8new.png"
                },
                new Animal
                {
                    Id = 8,
                    AnimalName = "Turtle",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante. ",
                    Rating = 4,
                    PathPhoto = "/images/Animal/9new.png"
                },
                new Animal
                {
                    Id = 9,
                    AnimalName = "Stingray",
                    AnimalDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia odio vitae vestibulum vestibulum. Cras venenatis euismod malesuada. Nullam ac erat ante.",
                    Rating = 5,
                    PathPhoto = "/images/Animal/10new.png"
                });


        }
    }
}
