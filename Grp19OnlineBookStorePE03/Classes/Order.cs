namespace Grp19OnlineBookStorePE03.Classes
{
    public class Order
    {
        public int OrderId { get; set; } //PK
        public List<OrderItem> OrderItems { get; set; } = new(); //Nav_Link_Out ( Order has > )
        public Payment? Payment { get; set; } //Nav_Link_Out ( Order has > )
        public int CustomerId { get; set; } //FK
        public Customer? Customer { get; set; } //Nav_Link_In ( has > Order )
        public string? OrderStatus { get; set; }
    }
}
