namespace Grp19OnlineBookStorePE03.Classes
{
    public class Staff
    {
        public int StaffId { get; set; } //PK
        public string? Name { get; set; }
        public string? Password { get; set; }
        public List<Misc> MiscItems { get; set; } = new(); //Nav_Link_Out ( Staff handles > )
        public List<Book> BookItems { get; set; } = new(); //Nav_Link_Out ( Staff handles > )
    }
}
