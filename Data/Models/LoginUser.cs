using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class LoginUser
    {

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
