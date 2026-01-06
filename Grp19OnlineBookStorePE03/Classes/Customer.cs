namespace Grp19OnlineBookStorePE03.Classes
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNum { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
