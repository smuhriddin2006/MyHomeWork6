using System.Data.Common;

namespace MainApp5;

public class Post
{
    public int Id {get; set;}
    public string Title {get; set;}= string.Empty;
    public string Description {get; set;}= string.Empty;
    public DateTime CreatedAt {get; set;}
    public int CategoryId {get; set;}

    static List<Post> posts = new List<Post>();
    public static void CreatePost(string title, string description, int categoryId)
    {
        int id = posts.Count + 1;
        var creatp = new Post
        {
            Title = title,
            Description = description,
            CategoryId = categoryId,
            CreatedAt = DateTime.Now
        }; 
        posts.Add(creatp);

    }

    public static List<Post> GetPosts()
    {
        return posts;
    }

    public static Post GetPostById(int id)
    {
        var find = posts.Find(f => f.Id == id);
        return find;
    }

    public static Post GetPostsByData(DateTime date)
    {
        var findDate = posts.Find(fd => fd.CreatedAt == date);
        return findDate;
    }

    public  void DeletePost(int id)
    {
        
        var del = posts.Find(p => p.Id == id);
        posts.Remove(del);

    
    }
    
}
