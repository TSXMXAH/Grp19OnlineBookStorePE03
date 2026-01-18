namespace Grp19OnlineBookStorePE03.Classes
{
    public class Book : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int PublishYear { get; set; }
        public string? CoverUrl { get; set; }
        public string? OpenLibraryWorkKey { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public BookStock? BookStock { get; set; }
    }
}
