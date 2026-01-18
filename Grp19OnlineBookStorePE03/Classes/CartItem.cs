using Grp19OnlineBookStorePE03.Data;

namespace Grp19OnlineBookStorePE03.Classes
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
