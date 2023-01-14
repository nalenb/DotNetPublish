namespace DotNetPublish.Shared;

public class BlogPost
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime DatePublished { get; set; } = DateTime.Now;
    public bool IsPublished { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
}
