using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
        public ICollection<ShoppingBasket> ShoppingBaskets { get; set; } = new List<ShoppingBasket>();
    }
}
