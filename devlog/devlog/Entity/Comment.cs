namespace devlog.Entity;

public class Comment
{
    public int CommentId { get; set; }
    public string? Text { get; set; }
    public int PostId { get; set; }
    public string? UserName { get; set; }
    public string? UserSurname { get; set; }
    public string? UserEmail { get; set; }
    public DateTime PublishedOn { get; set; }
    /* Each comment can contain one post. */
    public Post Post { get; set; } = null!;
}