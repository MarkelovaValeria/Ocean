namespace Ocean.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string guide { get; set; }
        public string location { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }
    }
}
