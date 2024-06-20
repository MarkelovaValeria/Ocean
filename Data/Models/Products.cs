using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PathPhoto { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(512)]
        public string DescriptionProduct {  get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public double Price { get; set; }
        public ICollection<ShoppingBasket> shoppingBaskets { get; set; } = new List<ShoppingBasket>();
    }
}
