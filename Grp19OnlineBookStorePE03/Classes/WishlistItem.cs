namespace Grp19OnlineBookStorePE03.Classes
{
    public class WishlistItem
    {
        public int WishlistItemId { get; set; }

        public string UserId { get; set; } = string.Empty;

        public int BookId { get; set; }

        public Book? Book { get; set; }
    }
}
