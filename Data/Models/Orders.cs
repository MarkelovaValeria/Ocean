using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Ocean.Data.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int? UsersId { get; set; }
        [Required]
        public  string Guide { get; set; }
        [Required]
        public  string Location { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [Required]
        public TimeOnly Time { get; set; }
        [Required]
        public string UserFullName { get; set; }
        [Required]
        public string UserEmail {  get; set; }
        public Users? Users { get; set; }
    }
}
