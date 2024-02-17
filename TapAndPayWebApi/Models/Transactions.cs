namespace TapAndPayWebApi.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}