namespace Grp19OnlineBookStorePE03.Classes
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string OrderStatus { get; set; } = "Pending";

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new();
        public Payment? Payment { get; set; }
    }
}
