namespace Grp19OnlineBookStorePE03.Classes
{
    public class Payment
    {
        public int PaymentId { get; set; } //PK
        public int OrderId { get; set; } //FK  
        public Order? Order   { get; set; } //Nav_link_In ( has > Payment )
        public decimal AmountPaid { get; set; }
    }
}
