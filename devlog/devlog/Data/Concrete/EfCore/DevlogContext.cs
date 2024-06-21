using devlog.Entity;
using Microsoft.EntityFrameworkCore;

namespace devlog.Data.Concrete.EfCore;

public class DevlogContext:DbContext
{
    public DevlogContext(DbContextOptions<DevlogContext> options): base(options)
    {
        
    }
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<User> Users => Set<User>();
}