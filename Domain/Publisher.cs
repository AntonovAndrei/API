namespace Domain;

public class Publisher
{
    public Publisher()
    {
        Books = new HashSet<Book>();
    }
    
    public DateTime CreateDate { get; set; }
    public string Location { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
}