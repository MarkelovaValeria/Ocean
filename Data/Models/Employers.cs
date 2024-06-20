using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Employers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(256)]
        public string DescriptionEmployer { get; set; }
        [Required]
        public string PathPhoto {  get; set; }
    }
}
