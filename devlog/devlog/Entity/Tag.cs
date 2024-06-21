namespace devlog.Entity;

public class Tag
{
    public int TagId { get; set; }
    public string? Text { get; set; }
    /* Each tag can contain more than one post. */
    public List<Post> Posts { get; set; } = new List<Post>();
}