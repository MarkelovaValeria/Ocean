using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int userId { get; set; }
        [Required]
        public string guide { get; set; }
        [Required]
        public string location { get; set; }
        [Required]

        public DateOnly date { get; set; }
        [Required]

        public TimeOnly time { get; set; }
    }
}
