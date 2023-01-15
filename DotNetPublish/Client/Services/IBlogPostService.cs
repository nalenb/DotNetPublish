namespace DotNetPublish.Client.Services;

public interface IBlogPostService
{
    List<BlogPost> GetBlogPosts();
    BlogPost? GetBlogPost(string slug);
}
