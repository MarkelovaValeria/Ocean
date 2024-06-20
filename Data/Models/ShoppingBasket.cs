using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ocean.Data.Models
{
    public class ShoppingBasket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UsersId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("UserId")]
        public Users Users { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
