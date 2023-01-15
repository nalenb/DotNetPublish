namespace DotNetPublish.Client.Services;

public interface IBlogPostService
{
    public Task<List<BlogPost>?> GetBlogPosts();
    public Task<BlogPost?> GetBlogPost(string slug);
}
