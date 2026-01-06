namespace Grp19OnlineBookStorePE03.Classes
{
    public class Misc : BaseDomainModel
    {
        public string? MiscName { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
