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
        return Ok(_context.BlogPosts);
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
}
