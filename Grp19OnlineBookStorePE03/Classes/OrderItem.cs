namespace Grp19OnlineBookStorePE03.Classes
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } //PK
        public int? OrderId { get; set; } //FK
        public Order? Order { get; set; } //Nav_Link_In (Order has>)
        public int? BookId { get; set; } //FK
        public Book? Book { get; set; } //Nav_Link_In (has> Book) 
        public int MiscId { get; set; } //FK
        public Misc? Misc { get; set; } //Nav_Link_In (has> Misc)
        public decimal Subtotal { get; set; }
    }
}
