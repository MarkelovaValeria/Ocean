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

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserName).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Surname).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Password).IsRequired().HasMaxLength(8);
            entity.HasMany(e => e.Orders).WithOne(e => e.Users).HasForeignKey(e => e.UsersId).IsRequired(false);
        });

        
       

    }
}
