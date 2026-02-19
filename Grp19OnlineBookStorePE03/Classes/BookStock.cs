namespace Grp19OnlineBookStorePE03.Classes
{
    public class BookStock : BaseDomainModel
    {
        public int BookId { get; set; }         
        public Book? Book { get; set; }          

        public int Quantity { get; set; }    
    }
}