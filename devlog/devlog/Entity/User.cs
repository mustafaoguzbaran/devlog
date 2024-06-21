namespace devlog.Entity;

public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    /* Each user can have more than one post. */
    public List<Post> Posts { get; set; } = new List<Post>();
}