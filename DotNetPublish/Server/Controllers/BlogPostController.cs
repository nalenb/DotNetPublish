using Microsoft.AspNetCore.Mvc;

namespace DotNetPublish.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogPostController : ControllerBase
{
    private readonly DataContext _context;

    public BlogPostController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<BlogPost>> Get()
    {
        return Ok(_context.BlogPosts.OrderByDescending(post => post.DatePublished));
    }

    [HttpGet("{slug}")]
    public ActionResult<BlogPost> Get(string slug)
    {
        var foundPost = _context.BlogPosts.FirstOrDefault(post => post.Slug.ToLower().Equals(slug.ToLower()));

        if (foundPost == null)
        {
            return NotFound("Post not found");
        }

        return Ok(foundPost);
    }

    [HttpPost]
    public async Task<ActionResult<BlogPost>> Post(BlogPost newBlogPost)
    {
        _context.Add(newBlogPost);
        await _context.SaveChangesAsync();

        return Ok(newBlogPost);
    }
}
