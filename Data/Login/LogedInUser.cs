using Ocean.Data.Models;

namespace Ocean.Data.Login
{
    public class LogedInUser
    {
        public  bool IsLogedIn { get; set; } = false;
        public Users users { get; set; }
    }
}
