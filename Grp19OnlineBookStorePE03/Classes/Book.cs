namespace Grp19OnlineBookStorePE03.Classes
{
    public class Book : BaseDomainModel
    {
        public string? BookName { get; set; }
        public string? Author { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
