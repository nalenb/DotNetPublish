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
        var result = await _http.GetAsync("api/BlogPost/");
        if (result.IsSuccessStatusCode)
        {
            return await result.Content.ReadFromJsonAsync<List<BlogPost>>();
        }

        return null;
    }

    public async Task<BlogPost?> GetBlogPost(string slug)
    {
        var result = await _http.GetAsync($"api/BlogPost/{slug}");
        if (result.IsSuccessStatusCode)
        {
            return await result.Content.ReadFromJsonAsync<BlogPost>();
        }

        return null;
    }
}
