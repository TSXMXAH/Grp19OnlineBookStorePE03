namespace Grp19OnlineBookStorePE03.Classes
{
    public class Misc
    {
        public int MiscId { get; set; } //PK
        public int StaffId { get; set; } //FK
        public Staff? Staff { get; set; } //Nav_Link_in ( handles > Misc ) 
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? MiscName { get; set; }
    }
}
