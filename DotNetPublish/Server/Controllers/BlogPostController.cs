using DotNetPublish.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPublish.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogPostController : ControllerBase
{
    private List<BlogPost> Posts = new List<BlogPost>()
    {
        new BlogPost { Slug = "first_post", Title = "First Post", Description = "This is my first description", Content = "This is the content of the first blog post" },
        new BlogPost { Slug = "second_post", Title = "Second Post", Description = "This is my second description", Content = "This is the content of the second blog post" }
    };

    [HttpGet]
    public ActionResult<List<BlogPost>> Get()
    {
        return Ok(Posts);
    }

    [HttpGet("{slug}")]
    public ActionResult<BlogPost> Get(string slug)
    {
        var foundPost = Posts.FirstOrDefault(post => post.Slug.ToLower().Equals(slug.ToLower()));

        if (foundPost == null)
        {
            return NotFound("Post not found");
        }

        return Ok(foundPost);
    }
}
