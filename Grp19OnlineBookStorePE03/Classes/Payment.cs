namespace Grp19OnlineBookStorePE03.Classes
{
    public class Payment:BaseDomainModel
    {
        public int OrderId { get; set; }   
        public Order? Order { get; set; }
        public string? UserId { get; set; }
        public decimal AmountPaid { get; set; } 
        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
