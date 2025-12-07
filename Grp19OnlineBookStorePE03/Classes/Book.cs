namespace Grp19OnlineBookStorePE03.Classes
{
    public class Book
    {
        public int BookId {  get; set; } //PK
        public int StaffId { get; set; } //FK
        public Staff? Staff { get; set; } //Nav_Link_In ( handles > Book )
        public string? Category {  get; set; }
        public decimal Price { get; set; }
        public string? Author { get; set; }
        public string? BookName { get; set; }
    }
}
