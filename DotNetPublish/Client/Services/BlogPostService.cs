using System.Net.Http.Json;

namespace DotNetPublish.Client.Services;

public class BlogPostService : IBlogPostService
{
    public HttpClient _http { get; }

    public BlogPostService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<BlogPost>?> GetBlogPosts()
    {
        var posts = await _http.GetFromJsonAsync<List<BlogPost>>("api/BlogPost/");

        return posts;
    }

    public async Task<BlogPost?> GetBlogPost(string slug)
    {
        var post = await _http.GetFromJsonAsync<BlogPost>($"api/BlogPost/{slug}");

        return post;
    }
}
