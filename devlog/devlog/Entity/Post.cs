namespace devlog.Entity;

public class Post
{
    public int PostId { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime PublishedOn { get; set; }
    public bool IsActive { get; set; }
    public int UserId { get; set;  }
    /* Each post will belong to a single user. */
    public User User { get; set; } = null!;
    /* Each post can have more than one Tag */
    public List<Tag> Tags { get; set; } = new List<Tag>();
    /* Each post may contain more than one comment. */
    public List<Comment> Comments { get; set; } = new List<Comment>();
}