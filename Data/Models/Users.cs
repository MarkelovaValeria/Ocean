using System.ComponentModel.DataAnnotations;

namespace Ocean.Data.Models
{
    public class Users
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

    }
}
