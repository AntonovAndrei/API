using Domain;
using Microsoft.EntityFrameworkCore;

namespace PostgrePersistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Publisher> Publishers { get; set; } = null!;
    
}