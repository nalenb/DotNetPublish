using System.ComponentModel.DataAnnotations;

namespace DotNetPublish.Shared;

public class BlogPost
{
    public int Id { get; set; }
    [Required, StringLength(50)]
    public string Slug { get; set; } = string.Empty;
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string Author { get; set; } = string.Empty;
    public string? CoverImage { get; set; }
    [Required]
    public string Content { get; set; } = string.Empty;
    public DateTime DatePublished { get; set; } = DateTime.Now;
    public bool IsPublished { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
}
