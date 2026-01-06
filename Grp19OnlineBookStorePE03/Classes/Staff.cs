namespace Grp19OnlineBookStorePE03.Classes
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public List<Book> BookItems { get; set; } = new(); 
        public List<Misc> MiscItems { get; set; } = new(); 
        
    }
}
