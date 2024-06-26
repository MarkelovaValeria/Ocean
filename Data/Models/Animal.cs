using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string AnimalName { get; set; }
        [Required]
        [MaxLength(256)]
        public string AnimalDescription { get; set; }
        public int Rating { get; set; }
        [Required]
        public string PathPhoto { get; set; }
    }
}
