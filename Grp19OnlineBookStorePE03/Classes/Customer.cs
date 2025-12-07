namespace Grp19OnlineBookStorePE03.Classes
{
    public class Customer
    {
        public int CustomerId { get; set; } //PK
        public List<Order> Orders { get; set; } = new(); //Nav_Lin_Out ( Customer has > )
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNum { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
