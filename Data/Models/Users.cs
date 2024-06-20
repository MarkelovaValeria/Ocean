using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }  
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
        public ICollection<ShoppingBasket> ShoppingBaskets { get; set; } = new List<ShoppingBasket>();
    }
}
