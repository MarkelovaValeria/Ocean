using Microsoft.EntityFrameworkCore;
using Ocean.Data;
using Ocean.Data.Models;
using System.Linq;

namespace Ocean.Services
{
    public class OceanService
    {
        private IDbContextFactory<DataContext> _dbContextFactory;

        public OceanService(IDbContextFactory<DataContext> dbContextFactory) { 
            _dbContextFactory = dbContextFactory;
        }

        public void AddUser(Users user) {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void AddOrder(Orders order)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public List<Employers> GetEmployers()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Employers.ToList();
            }
        }
        public Users GetUser(string email, string password)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Users.FirstOrDefault(user => user.Email.Equals(email) && user.Password.Equals(password));
            }
        }

        public List<Animal> GetAnimal()
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.ToList();
            }
        }
        public List<Animal> GetAnimalByName() {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.OrderBy(x=>x.AnimalName).ToList();
            }
        }
        public List<Animal> GetAnimalByRating()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.OrderBy(x => x.Rating).Take(3).ToList();
            }
        }
        public List<Animal> GetAnimalByRatingDown() {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.OrderByDescending(x=>x.Rating).Take(3).ToList();
            }
        }
        public List<Animal> GetAnimalByNameDown()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.OrderByDescending(x => x.AnimalName).ToList();
            }
        }

        public List<Animal> SearchAnimal(string str)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                return context.Animals.Where(x => x.AnimalName.Contains(str)).ToList();
            }
        }

        public void EditAccount(Users user)
        {
            
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }

        public void ExitAccount(Users user)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
