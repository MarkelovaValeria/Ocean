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

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserName).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Surname).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Password).IsRequired().HasMaxLength(8);
            entity.HasMany(e => e.Orders).WithOne(e => e.Users).HasForeignKey(e => e.UsersId).IsRequired(false);
        });
            modelBuilder.Entity<Employers>().HasData(
                new Employers {Id=1, FullName="Catherine Shevchenko", DescriptionEmployer= "Lorem ipsum dolor sit amet.", PathPhoto="/images/Employers/1.jpeg" },
                new Employers {Id=2, FullName= "Matthew Tkachenko", DescriptionEmployer= "Lorem ipsum dolor sit amet.", PathPhoto= "/images/Employers/2.jpeg" },
                new Employers {Id=3, FullName = "Lilia Petrenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/3.jpeg" },
                new Employers {Id=4, FullName = "Martin Goncharenko", DescriptionEmployer = "Lorem ipsum dolor sit amet.", PathPhoto = "/images/Employers/4.jpeg" }
                );
        }

        
       

    }
}
