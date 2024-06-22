using Microsoft.EntityFrameworkCore;
using Ocean.Data;
using Ocean.Data.Models;

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
    }
}
