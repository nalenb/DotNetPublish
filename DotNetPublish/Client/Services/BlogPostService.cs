namespace DotNetPublish.Client.Services;

public class BlogPostService : IBlogPostService
{
    private List<BlogPost> Posts = new List<BlogPost>()
    {
        new BlogPost { Slug = "first_post", Title = "First Post", Description = "This is my first description", Content = "This is the content of the first blog post" },
        new BlogPost { Slug = "second_post", Title = "Second Post", Description = "This is my second description", Content = "This is the content of the second blog post" }
    };

    List<BlogPost> IBlogPostService.GetBlogPosts()
    {
        return Posts;
    }

    BlogPost? IBlogPostService.GetBlogPost(string slug)
    {
        return Posts.FirstOrDefault(post => post.Slug.ToLower() == slug.ToLower());
    }
}
